using System.Collections.Generic;
using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting an <see cref="VoucherFormat"/> to a <see cref="string"/>
    /// </summary>
    public class VoucherFormatToStringJsonConverter : BaseEnumToStringJsonConverter<VoucherFormat>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VoucherFormatToStringJsonConverter() : base()
        {

        }

        #endregion

        /// <inheritdoc/>
        #region Protected Methods
        protected override IReadOnlyDictionary<VoucherFormat, string> GetMapper() 
            => SHOPFLIXConstants.VoucherFormatToStringMapper;

        #endregion

    }
}
