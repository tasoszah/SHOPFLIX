using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a collection of <see cref="ShipmentResponseModel"/>
    /// </summary>
    public class ShipmentsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Parameters"/> property
        /// </summary>
        private ParametersResponseModel? mParameters;

        /// <summary>
        /// The member of the <see cref="Shipments"/> property
        /// </summary>
        private IEnumerable<ShipmentResponseModel>? mShipments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The parameters
        /// </summary>
        [AllowNull]
        [JsonProperty("params")]
        public ParametersResponseModel Parameters
        {
            get => mParameters ??= new ParametersResponseModel();

            set => mParameters = value;
        }

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
