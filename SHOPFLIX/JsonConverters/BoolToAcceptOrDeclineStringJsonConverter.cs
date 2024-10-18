using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="bool"/> to an accept ("G") or a decline ("D") <see cref="string"/>
    /// </summary>
    public class BoolToAcceptOrDeclineStringJsonConverter : BaseBoolToStringJsonConverter
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BoolToAcceptOrDeclineStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override string GetFalseString() => "D";

        /// <inheritdoc/>
        protected override string GetTrueString() => "G";

        #endregion
    }
}
