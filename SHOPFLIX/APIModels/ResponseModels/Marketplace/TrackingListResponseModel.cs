using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        #region PublicProperties

        /// <summary>
        /// The entity ID
        /// </summary>
        [JsonProperty("EntityID")]
        public string EntityId { get; set; }

        /// <summary>
        /// The station name
        /// </summary>
        [JsonProperty("StationName")]
        public string StationName { get; set; }


        ///Array TO BE FIXED


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
