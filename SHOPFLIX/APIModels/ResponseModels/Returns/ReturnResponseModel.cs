using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a single return 
    /// </summary>
    public class ReturnResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The order id
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// The return order id
        /// </summary>
        [JsonProperty("return_order_id")]
        public int ReturnOrderId { get; set; }
        
        /// <summary>
        /// The id of the customer
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The order total
        /// </summary>
        [JsonProperty("total")]
        public decimal Total { get; set; }

        /// <summary>
        /// The order cost of products
        /// </summary>
        [JsonProperty("subtotal")]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// The order shipping cost
        /// </summary>
        [JsonProperty("shipping_cost")]
        public decimal ShippingCost { get; set; }

        /// <summary>
        /// The timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimeIntegerJsonConverter))]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The order status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(ReturnStatusToStringJsonConverter))]
        public ReturnStatus Status { get; set; }

        /// <summary>
        /// A list of the products that are be returned
        /// </summary>
        [JsonProperty("products")]
        public List<ReturnProductResponseModel> Products { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnResponseModel() : base()
        {

        }

        #endregion
    }
}
