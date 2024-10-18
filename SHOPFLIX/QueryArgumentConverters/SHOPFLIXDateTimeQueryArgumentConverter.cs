using System;
using System.Globalization;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="BaseQueryArgumentConverter{TValue}"/> that is used for converting a <see cref="DateTime"/> to a <see cref="string"/>
    /// using the SHOPFLIX requested <see cref="Format"/>
    /// </summary>
    public class SHOPFLIXDateTimeQueyArgumentConverter : BaseQueryArgumentConverter<DateTime>
    {
        #region Constants

        /// <summary>
        /// The format that is used for serializing the value
        /// </summary>
        public const string Format = "yyyy-MM-ddTHH:mm:ss";

        #endregion

        #region Constants

        /// <summary>
        /// Default constructor
        /// </summary>
        public SHOPFLIXDateTimeQueyArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string Convert(DateTime value) => value.ToString(Format, CultureInfo.InvariantCulture);

        #endregion
    }
}
