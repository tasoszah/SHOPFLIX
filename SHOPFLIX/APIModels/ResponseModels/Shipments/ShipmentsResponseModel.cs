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
    /// Represents a collection of <see cref="ShipmentResponseModel"/>
    /// </summary>
    public class ShipmentsResponseModel
    {
        #region Private Members

        private IEnumerable<ShipmentResponseModel>? mShipments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The list of shipments
        /// </summary>
        [AllowNull]
        [JsonProperty("shipments")]
        public IEnumerable<ShipmentResponseModel> Shipments
        {
            get => mShipments ?? Enumerable.Empty<ShipmentResponseModel>();

            set => mShipments = value;
        }

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
