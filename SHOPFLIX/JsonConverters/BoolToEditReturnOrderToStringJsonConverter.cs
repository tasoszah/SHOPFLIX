using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="bool"/> to an accept ("V") or a decline ("W") <see cref="string"/>
    /// </summary>
    public class BoolToEditReturnOrderToStringJsonConverter : BaseBoolToStringJsonConverter
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BoolToEditReturnOrderToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>   
        protected override string GetFalseString() => "W";

        /// <inheritdoc/>
        protected override string GetTrueString() => "V";

        #endregion
    }
}
