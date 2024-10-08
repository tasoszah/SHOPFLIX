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
    /// Represents the creation of a voucher via the SHOPFLIX Marketplace
    /// </summary>
    public class CreateVoucherResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ShipmentNumber"/> property
        /// </summary>
        private string? mShipmentNumber;

        /// <summary>
        /// The member of the <see cref="TrackingNumber"/> property
        /// </summary>
        private IEnumerable<string>? mTrackingNumbers;

        /// <summary>
        /// The member of the <see cref="ShipmentMasterId"/> property
        /// </summary>
        private string? mShipmentMasterId;

        /// <summary>
        /// The member of the <see cref="Result"/> property
        /// </summary>
        private string? mResult;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipment number
        /// </summary>
        [AllowNull]
        [JsonProperty("ShipmentNumber")]
        public string ShipmentNumber 
        {
            get => mShipmentNumber ?? string.Empty;

            set => mShipmentNumber = value;
        }

        /// <summary>
        /// The tracking numbers
        /// </summary>
        [AllowNull]
        [JsonProperty("TrackingNumbers")]
        public IEnumerable<string> TrackingNumber
        {
            get => mTrackingNumbers ?? Enumerable.Empty<string>();

            set => mTrackingNumbers = value;
        }

        /// <summary>
        /// The shipment master id
        /// </summary>
        [AllowNull]
        [JsonProperty("ShipmentMasterId")]
        public string ShipmentMasterId 
        {
            get => mShipmentMasterId ?? String.Empty;

            set => mShipmentMasterId = value;
        }

        /// <summary>
        /// A flag that indicates if the shipment already exists
        /// </summary>
        [JsonProperty("ShipmentAlreadyExists")]
        public bool DoesShipmentAlreadyExists { get; set; }

        /// <summary>
        /// The result
        /// </summary>
        [AllowNull]
        [JsonProperty("Result")]
        public string Result
        {
            get => mResult ?? String.Empty;

            set => mResult = value;
        }

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
