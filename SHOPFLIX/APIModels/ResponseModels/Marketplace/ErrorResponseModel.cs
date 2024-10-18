using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// The error list used at <see cref="PrintVoucherErrorResponseModel"/> and <see cref="CancelVoucherResponseModel"/>
    /// </summary>
    public class ErrorResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Code"/> property
        /// </summary>
        private string? mCode;

        /// <summary>
        /// The member of the <see cref="Severity"/> property
        /// </summary>
        private string? mSeverity;

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The error code
        /// </summary>
        [AllowNull]
        [JsonProperty("Code")]
        public string Code
        {
            get => mCode ?? string.Empty;

            set => mCode = value;
        }

        /// <summary>
        /// The severity
        /// </summary>
        [AllowNull]
        [JsonProperty("Severity")]
        public string Severity
        {
            get => mSeverity ?? string.Empty;

            set => mSeverity = value;
        }

        /// <summary>
        /// The error message
        /// </summary>
        [AllowNull]
        [JsonProperty("Message")]
        public string Message
        {
            get => mMessage ?? string.Empty;

            set => mMessage = value;
        }

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
