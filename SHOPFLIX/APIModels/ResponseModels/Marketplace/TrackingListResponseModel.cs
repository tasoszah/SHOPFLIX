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
    /// Representing the tracking list used at <see cref="ShipingRouteResponseModel"/>
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
            get => mEntityId ?? String.Empty;

            set => mEntityId = value;
        }

        /// <summary>
        /// The station name
        /// </summary>
        [AllowNull]
        [JsonProperty("StationName")]
        public string StationName
        {
            get => mStationName ?? String.Empty;

            set => mStationName = value;
        }

        // Array TO BE FIXED


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
