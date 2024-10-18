using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Representing the tracking list used at <see cref="ShipmentRouteResponseModel"/>
    /// </summary>
    public class TrackingListResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="EntityId"/> property
        /// </summary>
        private string? mEntityId;

        /// <summary>
        /// The member of the <see cref="StationName"/> property
        /// </summary>
        private string? mStationName;

        #endregion

        #region PublicProperties

        /// <summary>
        /// The entity ID
        /// </summary>
        [AllowNull]
        [JsonProperty("EntityID")]
        public string EntityId
        {
            get => mEntityId ?? string.Empty;

            set => mEntityId = value;
        }

        /// <summary>
        /// The station name
        /// </summary>
        [AllowNull]
        [JsonProperty("StationName")]
        public string StationName
        {
            get => mStationName ?? string.Empty;

            set => mStationName = value;
        }

        // TODO: array με την πορεία της αποστολής ανά στάδιο 


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TrackingListResponseModel() : base()
        {

        }

        #endregion
    }
}
