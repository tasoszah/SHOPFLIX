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
    /// Represents a collection of <see cref="OrderResponseModel"/>s
    /// </summary>
    public class OrdersResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Orders"/>
        /// </summary>
        private IEnumerable<OrderResponseModel>? mOrders;

        #endregion

        #region Public Properties

        /// <summary>
        /// The orders
        /// </summary>
        [AllowNull]
        [JsonProperty("orders")]
        public IEnumerable<OrderResponseModel> Orders
        {
            get => mOrders ?? Enumerable.Empty<OrderResponseModel>();

            set => mOrders = value;
        }

        /// <summary>
        /// Information related to the result
        /// </summary>
        [JsonProperty("params")]
        public ParametersResponseModel? Parameters { get; set; }

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
