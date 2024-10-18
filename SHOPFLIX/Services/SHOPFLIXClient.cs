using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// An agent capable for making API requests to the SHOPFLIX web API
    /// </summary>
    public class SHOPFLIXClient
    {
        #region Constants

        /// <summary>
        /// Error message indicating that an order can not be accepted
        /// </summary>
        public const string CanNotAcceptOrderErrorMessage = "Cannot Accept Order";

        /// <summary>
        /// Error message indicating that an invalid number of packages was specified at the <see cref="CreateVoucherAsync(int, uint)"/> method
        /// </summary>
        public const string InvalidNumberOfPackagesMessage = "Invalid number of packages. The number of packages should be greater or equal than 1!";

        #endregion

        #region Public Properties

        /// <summary>
        /// The credentials
        /// </summary>
        public SHOPFLIXCredentials Credentials { get; }

        /// <summary>
        /// A flag indicating whether the test environment should be used or not
        /// </summary>
        public bool ShouldUseTestEnvironment { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SHOPFLIXClient(SHOPFLIXCredentials credentials, bool shouldUseTestEnvironment) : base()
        {
            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
            ShouldUseTestEnvironment = shouldUseTestEnvironment;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the orders with additional information encapsulated in parameters
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public async Task<WebRequestResult<OrdersResponseModel>> GetOrdersWithParametersAsync(OrderAPIArgs? args = null)
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<OrdersResponseModel>(RouteHelpers.AttachParameters(APIRoutes.GetOrdersRoute(ShouldUseTestEnvironment), args), Credentials);
        }

        /// <summary>
        /// Gets the orders
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<MinimalOrderResponseModel>>> GetOrdersAsync(OrderAPIArgs? args = null)
        {
            var response = await GetOrdersWithParametersAsync(args);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<IEnumerable<MinimalOrderResponseModel>>();

            return response.ToSuccessfulWebRequestResult(x => x.Orders);
        }

        /// <summary>
        /// Gets the order with the specified <paramref name="orderNumber"/>
        /// </summary>
        /// <param name="orderNumber">The order number</param>
        /// <returns></returns>
        public async Task<WebRequestResult<OrderResponseModel>> GetOrderAsync(int orderNumber)
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<OrderResponseModel>(APIRoutes.GetOrderRoute(ShouldUseTestEnvironment, orderNumber), Credentials);
        }

        /// <summary>
        /// Accepts or declines the order with the specified <paramref name="orderNumber"/>
        /// </summary>
        /// <param name="orderNumber">The order number</param>
        /// <param name="shouldOrderBeAccepted">A flag indicating whether the order should be accepted or rejected</param>
        /// <returns></returns>
        public async Task<WebRequestResult> AcceptOrDeclineOrderAsync(int orderNumber, bool shouldOrderBeAccepted)
        {
            var response = await SHOPFLIXWebRequestsClient.Instance.PutAsync<MessageResponseModel>(APIRoutes.GetOrderRoute(ShouldUseTestEnvironment, orderNumber), new AcceptOrDeclineOrderRequestModel() { ShouldAcceptOrder = shouldOrderBeAccepted }, Credentials);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<object?>();

            if (response.Result.Message == CanNotAcceptOrderErrorMessage)
                return response.ToUnsuccessfulWebRequestResult<object?>(CanNotAcceptOrderErrorMessage);

            return response;
        }

        /// <summary>
        /// Gets the returns with additional information encapsulated in parameters
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ReturnsResponseModel>> GetReturnsWithParametersAsync(OrderAPIArgs? args = null)
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<ReturnsResponseModel>(RouteHelpers.AttachParameters(APIRoutes.GetReturnsRoute(ShouldUseTestEnvironment), args), Credentials);
        }

        /// <summary>
        /// Gets the returns 
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<MinimalReturnResponseModel>>> GetReturnsAsync(OrderAPIArgs? args = null)
        {
            var response = await GetReturnsWithParametersAsync(args);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<IEnumerable<MinimalReturnResponseModel>>();

            return response.ToSuccessfulWebRequestResult(x => x.Orders);
        }

        /// <summary>
        /// Gets the return with the specified <paramref name="returnNumber"/>
        /// </summary>
        /// <param name="returnNumber">The return number</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ReturnResponseModel>> GetReturnAsync(int returnNumber)
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<ReturnResponseModel>(APIRoutes.GetReturnRoute(ShouldUseTestEnvironment, returnNumber), Credentials);
        }

        /// <summary>
        /// Gets the shipments with additional information encapsulated in parameters
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentsResponseModel>> GetShipmentsWithParametersAsync()
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<ShipmentsResponseModel>(APIRoutes.GetShipmentsRoute(ShouldUseTestEnvironment), Credentials);
        }

        /// <summary>
        /// Gets the shipments
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<ShipmentResponseModel>>> GetShipments()
        {
            var response = await GetShipmentsWithParametersAsync();

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<IEnumerable<ShipmentResponseModel>>();

            return response.ToSuccessfulWebRequestResult(x => x.Shipments);
        }

        /// <summary>
        /// Gets the shipment with the specified <paramref name="shipmentNumber"/>
        /// </summary>
        /// <param name="shipmentNumber">The shipment number</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentResponseModel>> GetShipmentAsync(int shipmentNumber)
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<ShipmentResponseModel>(APIRoutes.GetShipmentRoute(ShouldUseTestEnvironment, shipmentNumber), Credentials);
        }

        /// <summary>
        /// Creates a voucher for the shipment with the specified <paramref name="shipmentNumber"/>
        /// </summary>
        /// <param name="shipmentNumber">The shipment number</param>
        /// <param name="numberOfPackages">The number of packages</param>
        /// <remarks>
        /// The number of packages should be equal or greater than 1.
        /// </remarks>
        /// <returns></returns>
        public async Task<WebRequestResult<CreateVoucherResponseModel>> CreateVoucherAsync(int shipmentNumber, uint numberOfPackages = 1)
        {
            if (numberOfPackages < 1)
                return new WebRequestResult<CreateVoucherResponseModel>
                {
                    ErrorMessage = InvalidNumberOfPackagesMessage
                };

            var response = await SHOPFLIXWebRequestsClient.Instance.GetAsync<InternalCreateVoucherResponseModel>(APIRoutes.CreateVoucherRoute(ShouldUseTestEnvironment, shipmentNumber, numberOfPackages), Credentials);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<CreateVoucherResponseModel>();

            if (!response.Result.Error.IsNullOrEmpty())
                return response.ToUnsuccessfulWebRequestResult<CreateVoucherResponseModel>(response.Result.Error);

            if (!response.Result.Message.IsNullOrEmpty())
                return response.ToUnsuccessfulWebRequestResult<CreateVoucherResponseModel>(response.Result.Message);

            return response.ToSuccessfulWebRequestResult(x => x.Voucher);
        }

        /// <summary>
        /// Cancels the voucher with the specified <paramref name="shipmentTrackingNumber"/>
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public async Task<WebRequestResult<CancelVoucherResponseModel>> CancelVoucherAsync(string shipmentTrackingNumber)
        {
            var response = await SHOPFLIXWebRequestsClient.Instance.GetAsync<CancelVoucherResponseModel>(APIRoutes.CancelVoucherRoute(ShouldUseTestEnvironment, shipmentTrackingNumber), Credentials);

            if (!response.IsSuccessful)
                return response;

            if (response.Result.Result != SHOPFLIXConstants.SuccessResultKeyword)
                return response.ToUnsuccessfulWebRequestResult<CancelVoucherResponseModel>(response.Result.Errors.AggregateString(x => x.Message));

            return response;
        }

        /// <summary>
        /// Prints the voucher with the specified <paramref name="shipmentTrackingNumber"/>
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <param name="voucherFormat">The voucher format</param>
        /// <returns></returns>
        public async Task<WebRequestResult<PrintVoucherSuccesResponseModel>> PrintVoucherAsync(string shipmentTrackingNumber, VoucherFormat voucherFormat)
        {
            var response = await SHOPFLIXWebRequestsClient.Instance.GetAsync<PrintVoucherSuccesResponseModel>(APIRoutes.PrintVoucherRoute(ShouldUseTestEnvironment, shipmentTrackingNumber, voucherFormat), Credentials);

            if (!response.IsSuccessful)
                return response;

            if (response.Result.Result != SHOPFLIXConstants.SuccessResultKeyword)
                return response.ToUnsuccessfulWebRequestResult<PrintVoucherSuccesResponseModel>(response.Result.Errors.AggregateString(x => x.Message));

            return response;
        }

        /// <summary>
        /// Retrieves tracking information for the voucher with the specified <paramref name="shipmentTrackingNumber"/>
        /// </summary>
        /// <param name="shipmentTrackingNumber">The shipment tracking number</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentRouteResponseModel>> ShipmentRouteAsync(string shipmentTrackingNumber)
        {
            return await SHOPFLIXWebRequestsClient.Instance.GetAsync<ShipmentRouteResponseModel>(APIRoutes.VoucherProgressRoute(ShouldUseTestEnvironment, shipmentTrackingNumber), Credentials);
        }

        #endregion
    }
}
