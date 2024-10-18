using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents information over the carrier company at <see cref="ShipmentResponseModel"/>
    /// </summary>
    public class CarrierInfoResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of the <see cref="TrackingUrl"/> property
        /// </summary>
        private string? mTrackingUrl;

        #endregion

        #region Public Properties

        /// <summary>
        /// The carrier company name
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;

            set => mName = value;
        }

        /// <summary>
        /// The tracking url
        /// </summary>
        [AllowNull]
        [JsonProperty("tracking_url")]
        public string TrackingUrl
        {
            get => mTrackingUrl ?? string.Empty;

            set => mTrackingUrl = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CarrierInfoResponseModel() : base()
        {

        }

        #endregion
    }
}
