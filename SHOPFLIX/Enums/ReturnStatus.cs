namespace SHOPFLIX
{
    /// <summary>
    /// Provides enumeration over the return statuses
    /// </summary>
    public enum ReturnStatus
    {
        /// <summary>
        /// Requested a return
        /// </summary>
        ReturnRequested,

        /// <summary>
        /// Return on the way to the store
        /// </summary>
        OnTheWayToTheStore,

        /// <summary>
        /// Return delivered to the store
        /// </summary>
        DeliveredToTheStore,

        /// <summary>
        /// The return is completed
        /// </summary>
        ReturnCompleted,

        /// <summary>
        /// The return is being processed
        /// </summary>
        ProcessingReturn,

        /// <summary>
        /// The return is declined
        /// </summary>
        ReturnDeclined

    }
}
