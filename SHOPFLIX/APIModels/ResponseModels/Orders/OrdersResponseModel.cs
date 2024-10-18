using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a collection of <see cref="MinimalOrderResponseModel"/>s
    /// </summary>
    public class OrdersResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Orders"/>
        /// </summary>
        private IEnumerable<MinimalOrderResponseModel>? mOrders;

        #endregion

        #region Public Properties

        /// <summary>
        /// The orders
        /// </summary>
        [AllowNull]
        [JsonProperty("orders")]
        public IEnumerable<MinimalOrderResponseModel> Orders
        {
            get => mOrders ?? Enumerable.Empty<MinimalOrderResponseModel>();

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
