using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="bool"/> to a '1/0' <see cref="string"/>
    /// </summary>
    public class BoolTo39AStatusStringJsonConverter : BaseBoolToStringJsonConverter
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BoolTo39AStatusStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override string GetFalseString() => "0";

        /// <inheritdoc/>
        protected override string GetTrueString() => "1";

        #endregion
    }
}
