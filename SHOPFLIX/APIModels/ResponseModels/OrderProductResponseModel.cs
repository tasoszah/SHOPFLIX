using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a product in the <see cref="OrderResponseModel"/> 
    /// </summary>
    public class OrderProductResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The item id
        /// </summary>
        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// The product id
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// The vendor sku
        /// </summary>
        [JsonProperty("vendor_sku")]
        public string VendorSku { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Extra information
        /// </summary>
        [JsonProperty("extra")]
        public List<OrderProductExtraResponseModel> Extra { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public OrderProductResponseModel()
        {

        }

        #endregion
    }
}
