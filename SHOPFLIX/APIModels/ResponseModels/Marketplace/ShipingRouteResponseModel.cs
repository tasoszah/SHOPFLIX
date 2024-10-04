using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Representing the shipping route
    /// </summary>
    public class ShipingRouteResponseModel
    {
        #region Public Properties

        /// <summary>
        /// An array of tracking comments about the shipment as implemented at <see cref="TrackingListResponseModel"/>
        /// </summary>
        [JsonProperty("TrackingList")]
        public List<TrackingListResponseModel> TrackingList { get; set; }

        /// <summary>
        /// The result 
        /// </summary>
        [JsonProperty("Result")]
        public string Result { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipingRouteResponseModel() : base()
        {

        }

        #endregion
    }
}
