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
    /// Represents base info of a product in the <see cref="OrderResponseModel"/>  and the <see cref="ReturnResponseModel"/>
    /// </summary>
    public class BaseProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="VendorSku"/> property
        /// </summary>
        private string? mVendorSku;

        #endregion

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
        [AllowNull]
        [JsonProperty("vendor_sku")]
        public string VendorSku
        {
            get => mVendorSku ?? String.Empty;

            set => mVendorSku = value;
        }

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

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public BaseProductResponseModel()
        {

        }

        #endregion
    }
}
