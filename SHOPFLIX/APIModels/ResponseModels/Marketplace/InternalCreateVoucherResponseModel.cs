using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    internal class InternalCreateVoucherResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Voucher"/> property
        /// </summary>
        private CreateVoucherResponseModel? mVoucher;

        #endregion

        #region Public Properties

        /// <summary>
        /// The voucher
        /// </summary>
        [AllowNull]
        [JsonProperty("voucher")]
        public CreateVoucherResponseModel Voucher
        {
            get => mVoucher ??= new CreateVoucherResponseModel();

            set => mVoucher = value;
        }

        /// <summary>
        /// The error message
        /// </summary>
        [JsonProperty("message")]
        internal string? Message { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        [JsonProperty("error")]
        internal string? Error { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InternalCreateVoucherResponseModel() : base()
        {

        }

        #endregion
    }
}
