namespace SHOPFLIX
{
    /// <summary>
    /// Provides enumeration over the shipment statuses
    /// </summary>
    public enum ShipmentStatus
    {
        /// <summary>
        /// Shipment is processing
        /// </summary>
        Processing,

        /// <summary>
        /// To be delivered
        /// </summary>
        ToBeDelivered,

        /// <summary>
        /// Shipped
        /// </summary>
        Shipped,

        /// <summary>
        /// Delivered
        /// </summary>
        Delivered,

        /// <summary>
        /// Failed to Deliver
        /// </summary>
        FailedToDeliver,

        /// <summary>
        /// Canceled
        /// </summary>
        Cancelled,

        /// <summary>
        /// Returned to store
        /// </summary>
        ReturnedToStore,

        /// <summary>
        /// Seller should be refunded
        /// </summary>
        SellerToBeRefunded
    }
}
