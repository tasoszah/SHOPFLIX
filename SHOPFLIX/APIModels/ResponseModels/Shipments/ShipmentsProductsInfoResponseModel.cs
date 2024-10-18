using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the product info as shown in the <see cref="ShipmentResponseModel"/> and <see cref="ShipmentsResponseModel"/>
    /// </summary>
    public class ShipmentsProductsInfoResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProductId"/> property
        /// </summary>
        private string? mProductsInfo;

        /// <summary>
        /// The member of the <see cref="ProductQuantity"/> property
        /// </summary>
        private string? mProductQuantity;

        #endregion

        #region Public Properties

        /// <summary>
        /// The product id
        /// </summary>
        [JsonProperty("products_id")]
        public string ProductId
        {
            get => mProductsInfo ?? string.Empty;

            set => mProductsInfo = value;
        }

        /// <summary>
        /// The product quantity
        /// </summary>
        [JsonProperty("products_qty")]
        public string ProductQuantity
        {
            get => mProductQuantity ?? string.Empty;

            set => mProductQuantity = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentsProductsInfoResponseModel() : base()
        {

        }

        #endregion
    }
}
