using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the creation of a voucher via the SHOPFLIX Marketplace
    /// </summary>
    public class CreateVoucherResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The shipment number
        /// </summary>
        [JsonProperty("ShipmentNumber")]
        public string ShipmentNumber { get; set; }

        /// <summary>
        /// The tracking numbers
        /// </summary>
        [JsonProperty("TrackingNumbers")]
        public List<string> TrackingNumber { get; set; }

        /// <summary>
        /// The shipment master id
        /// </summary>
        [JsonProperty("ShipmentMasterId")]
        public string ShipmentMasterId { get; set; }

        /// <summary>
        /// A flag that indicates if the shipment already exists
        /// </summary>
        [JsonProperty("ShipmentAlreadyExists")]
        public bool DoesShipmentAlreadyExists { get; set; }

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
        public CreateVoucherResponseModel() : base()
        {
                
        }

        #endregion
    }
}
