using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represent a failed print of a voucher
    /// </summary>
    internal class PrintVoucherErrorResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The result
        /// </summary>
        [JsonProperty("Result")]
        public string Result { get; set; }

        /// <summary>
        /// A list of errors represented as an <see cref="ErrorResponseModel"/> 
        /// </summary>
        [JsonProperty("Errors")]
        public List<ErrorResponseModel> Errors { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrintVoucherErrorResponseModel() : base()
        {

        }

        #endregion
    }
}
