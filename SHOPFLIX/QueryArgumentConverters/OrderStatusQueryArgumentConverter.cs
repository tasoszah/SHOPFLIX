namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="OrderStatus"/> to a <see cref="string"/>
    /// </summary>
    public class OrderStatusQueryArgumentConverter : BaseQueryArgumentConverter<OrderStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderStatusQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(OrderStatus value) => SHOPFLIXConstants.OrderStatusToStringMapper[value];

        #endregion
    }
}
