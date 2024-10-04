using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// API routes related to SHOPFLIX
    /// </summary>
    public static class APIRoutes
    {

        public const string DateFormat = "yyyy-MM-dd";

        public const string ProductionRoute = "https://shopflix.gr/api/";

        public const string TestingRoute = "https://wellcomm.com.gr/api/";

        public static string GetBaseRoute(bool shouldUseTestEnvironment)
        {
            if (shouldUseTestEnvironment)
                return TestingRoute;

            return ProductionRoute;
        }

        public static string GetOrdersListRoute(bool shouldUseTestEnvironment) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/orders/";

        public static string GetOrdersListBasedOnStatusRoute(bool shouldUseTestEnvironment, OrderStatus orderStatus)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/orders/?status={orderStatus}";

        public static string GetOrdersBasedOnDateRangeListRoute(bool shouldUseTestEnvironment, DateOnly dateFrom, DateOnly dateTo)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/orders/?date_from={dateFrom.ToString(DateFormat)}&date_to={dateTo.ToString(DateFormat)}";

        public static string GetSingleOrderRoute(bool shouldUseTestEnvironment, string orderNumber) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/orders/{orderNumber}";

        public static string ChangeOrderStatusRoute(bool shouldUseTestEnvironment, string orderNumber) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/orders/{orderNumber}";

        public static string GetReturnsListRoute(bool shouldUseTestEnvironment) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/returns";

        public static string GetReturnsListBasedOnStatusRoute(bool shouldUseTestEnvironment, ReturnStatus returnStatus)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/returns/?status={returnStatus}";

        public static string GetReturnsBasedOnDateFromListRoute(bool shouldUseTestEnvironment, DateOnly dateFrom)
           => $"{GetBaseRoute(shouldUseTestEnvironment)}/returns/?date_from={dateFrom.ToString(DateFormat)}";

        public static string GetReturnsBasedOnDateRangeListRoute(bool shouldUseTestEnvironment, DateOnly dateFrom, DateOnly dateTo)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/returns/?date_from={dateFrom.ToString(DateFormat)}&date_to={dateTo.ToString(DateFormat)}";

        public static string ChangeReturnStatusRoute(bool shouldUseTestEnvironment, string returnNumber) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/returns/{returnNumber}";

        public static string GetShipmentsListRoute(bool shouldUseTestEnvironment) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments";

        public static string GetSingleShipmentRoute(bool shouldUseTestEnvironment, string shipmentId) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments/{shipmentId}";

        public static string CreateVoucherRoute(bool shouldUseTestEnvironment, string shipmentId) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/{shipmentId}";

        public static string CreateVoucherWithPackagesRoute(bool shouldUseTestEnvironment, string shipmentId, int numberOfPackages) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/{shipmentId}?number_of_packages={numberOfPackages}";
 
        public static string CancelVoucherRoute(bool shouldUseTestEnvironment, string voucherNumber) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/?cancel={voucherNumber}";

        public static string PrintSingleOrderVoucherRoute(bool shouldUseTestEnvironment, string voucherNumber, VoucherFormat voucherFormat ) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/?print={voucherNumber}&labelFormat={voucherFormat}";

        public static string PrintOrderVoucherListRoute(bool shouldUseTestEnvironment, List<string> voucherNumbers, VoucherFormat voucherFormat) 
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/?print={string.Join(",", voucherNumbers)}&labelFormat={voucherFormat}";

        public static string SingleVoucherProgressRoute(bool shouldUseTestEnvironment, string voucherNumber)
           => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/?trackingnumber={voucherNumber}";

    }
}
