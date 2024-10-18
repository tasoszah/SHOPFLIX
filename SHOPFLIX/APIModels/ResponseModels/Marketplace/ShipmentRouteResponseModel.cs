using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Representing the shipping route
    /// </summary>
    public class ShipmentRouteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TrackingList"/> property
        /// </summary>
        private IEnumerable<TrackingListResponseModel>? mTrackingList;

        /// <summary>
        /// The member of the <see cref="Result"/> property
        /// </summary>
        private string? mResult;

        #endregion

        #region Public Properties

        /// <summary>
        /// An array of tracking comments about the shipment as implemented at <see cref="TrackingListResponseModel"/>
        /// </summary>
        [AllowNull]
        [JsonProperty("TrackingList")]
        public IEnumerable<TrackingListResponseModel> TrackingList
        {
            get => mTrackingList ?? Enumerable.Empty<TrackingListResponseModel>();

            set => mTrackingList = value;
        }

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
        public ShipmentRouteResponseModel() : base()
        {

        }

        #endregion
    }
}
