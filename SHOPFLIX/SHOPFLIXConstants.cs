using System.Collections.Generic;

namespace SHOPFLIX
{
    /// <summary>
    /// Constants related to SHOPFLIX
    /// </summary>
    public static class SHOPFLIXConstants
    {
        /// <summary>
        /// A keyword that is usually placed on a 'Result' property and is used for indicating a successful result
        /// </summary>
        public const string SuccessResultKeyword = "Success";

        /// <summary>
        /// Maps the <see cref="OrderStatus"/>es to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<OrderStatus, string> OrderStatusToStringMapper { get; } = new Dictionary<OrderStatus, string>()
        {
            {OrderStatus.Placed, "O" },
            {OrderStatus.Processing, "G" },
            {OrderStatus.ToBeShipped, "H" },
            {OrderStatus.Shipped, "J" },
            {OrderStatus.PartialDelivery, "E" },
            {OrderStatus.FailedToDeliver, "L" },
            {OrderStatus.Delivered, "K" },
            {OrderStatus.Rejected, "D" },
            {OrderStatus.Canceled, "I" },
            {OrderStatus.Completed, "C" }
        };

        /// <summary>
        /// Maps the <see cref="ReturnStatus"/>es to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ReturnStatus, string> ReturnStatusToStringMapper { get; } = new Dictionary<ReturnStatus, string>()
        {
            {ReturnStatus.ReturnRequested, "U" },
            {ReturnStatus.OnTheWayToTheStore, "A" },
            {ReturnStatus.DeliveredToTheStore, "T" },
            {ReturnStatus.ReturnCompleted, "V" },
            {ReturnStatus.ProcessingReturn, "W" },
            {ReturnStatus.ReturnDeclined, "X" }
        };

        /// <summary>
        /// Maps the <see cref="ShipmentStatus"/>es to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<ShipmentStatus, string> ShipmentStatusToStringMapper { get; } = new Dictionary<ShipmentStatus, string>()
        {
            {ShipmentStatus.Processing, "P" },
            {ShipmentStatus.ToBeDelivered, "A" },
            {ShipmentStatus.Shipped, "S" },
            {ShipmentStatus.Delivered, "B" },
            {ShipmentStatus.FailedToDeliver, "C" },
            {ShipmentStatus.Cancelled, "D" },
            {ShipmentStatus.ReturnedToStore, "E" },
            {ShipmentStatus.SellerToBeRefunded, "F" }
        };

        /// <summary>
        /// Maps the <see cref="VoucherFormat"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<VoucherFormat, string> VoucherFormatToStringMapper { get; } = new Dictionary<VoucherFormat, string>()
        {
            {VoucherFormat.PDF , "PDF" },
            {VoucherFormat.Clean, "Clean" }
        };
    }
}
