using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents base info of a product in the <see cref="MinimalOrderResponseModel"/>  and the <see cref="MinimalReturnResponseModel"/>
    /// </summary>
    public class BaseProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ItemId"/> property
        /// </summary>
        private string? mItemId;

        /// <summary>
        /// The member of the <see cref="ProductStatus"/> property
        /// </summary>
        private string? mProductStatus;

        /// <summary>
        /// The member of the <see cref="ProductId"/> property
        /// </summary>
        private string? mProductId;

        /// <summary>
        /// The member of the <see cref="ProductCode"/> property
        /// </summary>
        private string? mProductCode;

        /// <summary>
        /// The member of the <see cref="Product"/> property
        /// </summary>
        private string? mProduct;

        /// <summary>
        /// The member of the <see cref="MasterProductCode"/>
        /// </summary>
        private string? mMasterProductCode;

        /// <summary>
        /// The member of the <see cref="CompanyId"/> property
        /// </summary>
        private string? mCompanyId;

        /// <summary>
        /// The member of the <see cref="EAN"/> property
        /// </summary>
        private string? mEAN;

        #endregion

        #region Public Properties

        /// <summary>
        /// The product id
        /// </summary>
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// The product status
        /// </summary>
        [AllowNull]
        [JsonProperty("product_status")]
        public string ProductStatus
        {
            get => mProductStatus ?? string.Empty;

            set => mProductStatus = value;
        }

        /// <summary>
        /// The product code
        /// </summary>
        [AllowNull]
        [JsonProperty("product_code")]
        public string ProductCode
        {
            get => mProductCode ?? string.Empty;

            set => mProductCode = value;
        }

        /// <summary>
        /// The product name
        /// </summary>
        [AllowNull]
        [JsonProperty("product")]
        public string Product
        {
            get => mProduct ?? string.Empty;

            set => mProduct = value;
        }

        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The original price
        /// </summary>
        [JsonProperty("original_price")]
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// The order id
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// The master product code
        /// </summary>
        [AllowNull]
        [JsonProperty("master_product_code")]
        public string MasterProductCode
        {
            get => mMasterProductCode ?? string.Empty;

            set => mMasterProductCode = value;
        }

        /// <summary>
        /// The company id
        /// </summary>
        [AllowNull]
        [JsonProperty("company_id")]
        public string CompanyId
        {
            get => mCompanyId ?? string.Empty;

            set => mCompanyId = value;
        }

        /// <summary>
        /// The item id
        /// </summary>
        [AllowNull]
        [JsonProperty("item_id")]
        public string ItemId
        {
            get => mItemId ?? string.Empty;

            set => mItemId = value;
        }

        /// <summary>
        /// The product id
        /// </summary>
        [AllowNull]
        [JsonProperty("product_id")]
        public string ProductId
        {
            get => mProductId ?? string.Empty;

            set => mProductId = value;
        }

        /// <summary>
        /// The EAN
        /// </summary>
        [AllowNull]
        [JsonProperty("ean")]
        public string EAN
        {
            get => mEAN ?? string.Empty;

            set => mEAN = value;
        }

        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("base_price")]
        public decimal BasePrice { get; set; }

        /// <summary>
        /// The quantity of the product
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
