using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// Request model used for accepting or rejecting an order
    /// </summary>
    public class AcceptOrDeclineOrderRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A flag indicating whether the order should be accepted or rejected.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If <see cref="true"/>, then the order is accepted.
        /// </para>
        /// <para>
        /// If <see cref="false"/>, then the order is rejected.
        /// </para>
        /// </remarks>
        [JsonProperty("status")]
        [JsonConverter(typeof(BoolToAcceptOrDeclineStringJsonConverter))]
        public bool ShouldAcceptOrder { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AcceptOrDeclineOrderRequestModel() : base()
        {

        }

        #endregion
    }
}
