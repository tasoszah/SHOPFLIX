using System.Collections.Generic;

namespace SHOPFLIX
{
    /// <summary>
    /// API routes related to SHOPFLIX
    /// </summary>
    public static class APIRoutes
    {
        public const string ProductionRoute = "https://shopflix.gr/api";

        public const string TestingRoute = "https://4bg28dqy1b.execute-api.eu-central-1.amazonaws.com/api";

        public static string GetBaseRoute(bool shouldUseTestEnvironment)
        {
            if (shouldUseTestEnvironment)
                return TestingRoute;

            return ProductionRoute;
        }

        public static string GetOrdersRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/orders";

        public static string GetOrderRoute(bool shouldUseTestEnvironment, int orderNumber)
            => $"{GetOrdersRoute(shouldUseTestEnvironment)}/{orderNumber}";

        public static string GetReturnsRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/returns";

        public static string GetReturnRoute(bool shouldUseTestEnvironment, int returnNumber)
            => $"{GetReturnsRoute(shouldUseTestEnvironment)}/{returnNumber}";

        public static string GetShipmentsRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments";

        public static string GetShipmentRoute(bool shouldUseTestEnvironment, int shipmentId)
            => $"{GetShipmentsRoute(shouldUseTestEnvironment)}/{shipmentId}";

        public static string CreateVoucherRoute(bool shouldUseTestEnvironment, int shipmentId, uint numberOfPackages)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier/{shipmentId}?number_of_packages={numberOfPackages}";

        public static string CancelVoucherRoute(bool shouldUseTestEnvironment, string shipmentTrackingNumber)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier?cancel={shipmentTrackingNumber}";

        public static string PrintVoucherRoute(bool shouldUseTestEnvironment, string shipmentTrackingNumber, VoucherFormat voucherFormat)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier?print={shipmentTrackingNumber}&labelFormat={SHOPFLIXConstants.VoucherFormatToStringMapper[voucherFormat].ToLower()}";

        public static string PrintVouchersRoute(bool shouldUseTestEnvironment, IEnumerable<string> shipmentTrackingNumbers, VoucherFormat voucherFormat)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier?print={string.Join(",", shipmentTrackingNumbers)}&labelFormat={SHOPFLIXConstants.VoucherFormatToStringMapper[voucherFormat].ToLower()}";

        public static string VoucherProgressRoute(bool shouldUseTestEnvironment, string shipmentTrackingNumber)
           => $"{GetBaseRoute(shouldUseTestEnvironment)}/courier?trackingnumber={shipmentTrackingNumber}";

    }
}
