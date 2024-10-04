using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{   
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting an <see cref="ReturnStatus"/> to a <see cref="string"/>
    /// </summary>
    public class ReturnStatusToStringJsonConverter : BaseEnumToStringJsonConverter<ReturnStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnStatusToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ReturnStatus, string> GetMapper() 
            => SHOPFLIXConstants.ReturnStatusToStringMapper;

        #endregion
    }
}
