using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Request model used for accepting or rejecting a returned order
    /// </summary>
    public class ChangeReturnedOrderStatusRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A flag indicating whether the returned order should be accepted or rejected.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If <see cref="true"/>, then the order is accepted.
        /// </para>
        /// <para>
        /// If <see cref="false"/>, then the order is rejected.
        /// </para>
        /// </remarks>
        [JsonProperty("status")]
        [JsonConverter(typeof(BoolToEditReturnOrderToStringJsonConverter))]
        public bool Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChangeReturnedOrderStatusRequestModel() : base()
        {

        }

        #endregion
    }
}
