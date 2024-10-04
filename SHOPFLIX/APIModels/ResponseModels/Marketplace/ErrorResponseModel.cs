using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// The error list used at <see cref="PrintVoucherErrorResponseModel"/> and <see cref="CancelVoucherResponseModel"/>
    /// </summary>
    public class ErrorResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("Code")] 
        public string Code { get; set; }

        /// <summary>
        /// The severity
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        [JsonProperty("Message")]
        public string Message { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ErrorResponseModel() : base()
        {

        }

        #endregion
    }
}
