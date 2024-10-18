using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

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

        /// <summary>
        /// The member of the <see cref="Voucher"/> property
        /// </summary>
        private string? mVoucher;

        /// <summary>
        /// The member of the <see cref="Errors"/> property
        /// </summary>
        private IEnumerable<ErrorResponseModel>? mErrors;

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
        /// The voucher in Base64 format
        /// </summary>
        [AllowNull]
        [JsonProperty("Voucher")]
        public string Voucher
        {
            get => mVoucher ?? string.Empty;

            set => mVoucher = value;
        }

        /// <summary>
        /// The result
        /// </summary>
        [AllowNull]
        [JsonProperty("Success")]
        internal string Result
        {
            get => mResult ?? string.Empty;

            set => mResult = value;
        }

        /// <summary>
        /// The errors
        /// </summary>
        [AllowNull]
        [JsonProperty("Errors")]
        internal IEnumerable<ErrorResponseModel> Errors
        {
            get => mErrors ?? Enumerable.Empty<ErrorResponseModel>();

            set => mErrors = value;
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
