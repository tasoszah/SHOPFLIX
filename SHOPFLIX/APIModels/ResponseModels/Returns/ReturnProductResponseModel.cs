using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a product in a <see cref="MinimalReturnResponseModel"/>
    /// </summary>
    public class ReturnProductResponseModel : BaseProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ReasonText"/> property
        /// </summary>
        private string? mReasonText;

        #endregion

        #region Public Properties

        /// <summary>
        /// The id of the reason of return
        /// </summary>
        [JsonProperty("reason_id")]
        public int ReasonId { get; set; }

        /// <summary>
        /// The text for the reason of return
        /// </summary>
        [AllowNull]
        [JsonProperty("reason_text")]
        public string ReasonText
        {
            get => mReasonText ?? string.Empty;

            set => mReasonText = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnProductResponseModel() : base()
        {

        }

        #endregion
    }
}
