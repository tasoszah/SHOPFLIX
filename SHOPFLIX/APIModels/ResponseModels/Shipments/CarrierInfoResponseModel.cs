using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents information over the carrier company at <see cref="ShipmentResponseModel"/>
    /// </summary>
    public class CarrierInfoResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The carrier company name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The tracking url
        /// </summary>
        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

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
