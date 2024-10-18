namespace SHOPFLIX
{
    /// <summary>
    /// Provides enumeration over the order statuses
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Placed order
        /// </summary>
        Placed,

        /// <summary>
        /// Processing order
        /// </summary>
        Processing,

        /// <summary>
        /// Order to be shipped
        /// </summary>
        ToBeShipped,

        /// <summary>
        /// Shipped order
        /// </summary>
        Shipped,

        /// <summary>
        /// Partial delivery
        /// </summary>
        PartialDelivery,

        /// <summary>
        /// Order failed to deliver
        /// </summary>
        FailedToDeliver,

        /// <summary>
        /// Order delivered
        /// </summary>
        Delivered,

        /// <summary>
        /// Order rejected
        /// </summary>
        Rejected,

        /// <summary>
        /// Order canceled
        /// </summary>
        Canceled,

        /// <summary>
        /// Order completed
        /// </summary>
        Completed

    }
}
