using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a successful printing of a voucher
    /// </summary>
    public class PrintVoucherSuccesResponseModel
    {

        #region Public Properties

        /// <summary>
        /// The voucher format
        /// </summary>
        [JsonProperty("VoucherFormat")]
        public VoucherFormat VoucherFormat { get; set; }

        /// <summary>
        /// A list of data of the voucher
        /// </summary>
        [JsonProperty("VoucherDataList")]
        public List<string> VoucherDataList { get; set; }

        /// <summary>
        /// A list of data of the returned voucher
        /// </summary>
        [JsonProperty("VoucherDataReturnList")]
        public List<string> VoucherDataReturnList { get; set; }

        /// <summary>
        /// The result
        /// </summary>
        [JsonProperty("Success")]
        public string Result { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrintVoucherSuccesResponseModel() : base()
        {

        }

        #endregion
    }
}
