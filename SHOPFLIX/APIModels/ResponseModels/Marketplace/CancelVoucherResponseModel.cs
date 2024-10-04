using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the cancellation of a voucher
    /// </summary>
    public class CancelVoucherResponseModel
    {

        #region Public Properties

        /// <summary>
        /// A flag that indicates if the shipment already exists
        /// </summary>
        [JsonProperty("ShipmentAlreadyExist")]
        public bool DoesShipmentAlreadyExist { get; set; }

        /// <summary>
        /// The result
        /// </summary>
        [JsonProperty("Result")]
        public string Result { get; set; }

        /// <summary>
        /// A list of errors represented as an <see cref="ErrorResponseModel"/>
        /// </summary>
        [JsonProperty("Errors")]
        public List<ErrorResponseModel> Errors { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelVoucherResponseModel() : base()
        {

        }

        #endregion

    }
}
