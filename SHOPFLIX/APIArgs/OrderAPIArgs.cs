using SHOPFLIX.APIArgs;

namespace SHOPFLIX
{
    /// <summary>
    /// Arguments used for retrieving orders
    /// </summary>
    public class OrderAPIArgs : BaseDateBasedAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Limit the result set to entries with specific status
        /// </summary>
        [Name("status")]
        [QueryArgumentConverter<OrderStatusQueryArgumentConverter>]
        public OrderStatus? Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderAPIArgs() : base()
        {

        }

        #endregion
    }
}
