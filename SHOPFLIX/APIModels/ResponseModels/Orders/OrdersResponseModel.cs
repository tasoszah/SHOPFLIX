using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a collection of <see cref="OrderResponseModel"/>s
    /// </summary>
    public class OrdersResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The orders
        /// </summary>
        [JsonProperty("orders")]
        public List<OrderResponseModel> Orders { get; set; }

        /// <summary>
        /// Information related to the result
        /// </summary>
        [JsonProperty("params")]
        public ParametersResponseModel Parameters { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrdersResponseModel() : base()
        {

        }

        #endregion
    }
}
