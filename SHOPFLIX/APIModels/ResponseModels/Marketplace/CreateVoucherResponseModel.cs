using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

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
        /// The member of the <see cref="TrackingNumbers"/> property
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
        public IEnumerable<string> TrackingNumbers
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
            get => mShipmentMasterId ?? string.Empty;

            set => mShipmentMasterId = value;
        }

        /// <summary>
        /// A flag that indicates if the shipment already exists
        /// </summary>
        [JsonProperty("ShipmentAlreadyExists")]
        internal bool DoesShipmentAlreadyExists { get; set; }

        /// <summary>
        /// The result
        /// </summary>
        [AllowNull]
        [JsonProperty("Result")]
        internal string Result
        {
            get => mResult ?? string.Empty;

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
