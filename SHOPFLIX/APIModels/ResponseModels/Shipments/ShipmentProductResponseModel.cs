using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    public class ShipmentProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProductCode"/> property
        /// </summary>
        private string? mCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The product id
        /// </summary>
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// The quantity of the product
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The base price of the product
        /// </summary>
        [JsonConverter(typeof(DecimalToIntJsonConverter))]
        [JsonProperty("base_price")]
        public decimal BasePrice { get; set; }

        /// <summary>
        /// The item id
        /// </summary>
        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// The order id
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// The original price
        /// </summary>
        [JsonConverter(typeof(DecimalToIntJsonConverter))]
        [JsonProperty("original_price")]
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [JsonConverter(typeof(DecimalToIntJsonConverter))]
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The product code
        /// </summary>
        [AllowNull]
        [JsonProperty("product_code")]
        public string ProductCode
        {
            get => mCode ?? string.Empty;

            set => mCode = value;
        }

        /// <summary>
        /// The product id
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// The total price
        /// </summary>
        [JsonConverter(typeof(DecimalToIntJsonConverter))]
        [JsonProperty("total_price")]
        public decimal TotalPrice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentProductResponseModel() : base()
        {

        }

        #endregion
    }
}
