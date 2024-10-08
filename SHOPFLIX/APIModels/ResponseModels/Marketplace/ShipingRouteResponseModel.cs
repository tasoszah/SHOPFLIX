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
    /// Representing the shipping route
    /// </summary>
    public class ShipingRouteResponseModel
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
        public ShipingRouteResponseModel() : base()
        {

        }

        #endregion
    }
}
