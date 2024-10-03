using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a collection of <see cref="ShipmentResponseModel"/>
    /// </summary>
    public class ShipmentsResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The list of shipments
        /// </summary>
        [JsonProperty("shipments")]
        public List<ShipmentResponseModel> Shipments { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentsResponseModel() : base()
        {

        }

        #endregion
    }
}
