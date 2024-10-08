using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        #region Private Members

        /// <summary>
        /// The member of the <see cref="VoucherDataList"/> property
        /// </summary>
        private IEnumerable<string>? mVoucherDataList;

        /// <summary>
        /// The member of the <see cref="VoucherDataReturnList"/> property
        /// </summary>
        private IEnumerable<string>? mVoucherDataReturnList;

        /// <summary>
        /// The member of the <see cref="Result"/> property
        /// </summary>
        private string? mResult;

        #endregion

        #region Public Properties

        /// <summary>
        /// The voucher format
        /// </summary>
        [JsonProperty("VoucherFormat")]
        public VoucherFormat VoucherFormat { get; set; }

        /// <summary>
        /// A list of data of the voucher
        /// </summary>
        [AllowNull]
        [JsonProperty("VoucherDataList")]
        public IEnumerable<string> VoucherDataList
        {
            get => mVoucherDataList ?? Enumerable.Empty<string>();

            set => mVoucherDataList = value;
        }

        /// <summary>
        /// A list of data of the returned voucher
        /// </summary>
        [AllowNull]
        [JsonProperty("VoucherDataReturnList")]
        public IEnumerable<string> VoucherDataReturnList
        {
            get => mVoucherDataReturnList ?? Enumerable.Empty<string>();

            set => mVoucherDataReturnList = value;  
        }

        /// <summary>
        /// The result
        /// </summary>
        [AllowNull]
        [JsonProperty("Success")]
        public string Result
        {
            get => mResult ?? String.Empty;

            set => mResult = value;
        }

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
