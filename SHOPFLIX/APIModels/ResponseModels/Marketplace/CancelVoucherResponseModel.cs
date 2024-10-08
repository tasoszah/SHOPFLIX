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
    /// Represents the cancellation of a voucher
    /// </summary>
    public class CancelVoucherResponseModel
    {
        #region Private Members 

        /// <summary>
        /// The member of the <see cref="Result"/> property
        /// </summary>
        private string? mResult;

        /// <summary>
        /// The member of the <see cref="Errors"/>
        /// </summary>
        private IEnumerable<ErrorResponseModel>? mErrors;

        #endregion

        #region Public Properties

        /// <summary>
        /// A flag that indicates if the shipment already exists
        /// </summary>
        [JsonProperty("ShipmentAlreadyExist")]
        public bool DoesShipmentAlreadyExist { get; set; }

        /// <summary>
        /// The result
        /// </summary>
        [AllowNull]
        [JsonProperty("Result")]
        public string Result
        {
            get => mResult ?? string.Empty;

            set => mResult = value;
        }

        /// <summary>
        /// A list of errors represented as an <see cref="ErrorResponseModel"/>
        /// </summary>
        [AllowNull]
        [JsonProperty("Errors")]
        public IEnumerable<ErrorResponseModel> Errors
        {
            get => mErrors ?? Enumerable.Empty<ErrorResponseModel>();

            set => mErrors = value;
        }

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
