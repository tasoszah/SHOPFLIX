using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a set of extra information related to an order product
    /// </summary>
    public class OrderProductResponseModel : BaseProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Extra"/> property
        /// </summary>
        private OrderProductExtraResponseModel? mExtra;

        #endregion

        #region Public Properties

        /// <summary>
        /// The product url 
        /// </summary>
        [JsonProperty("product_url")]
        public Uri? ProductUrl { get; set; }

        /// <summary>
        /// The status of 39A
        /// </summary>
        [JsonProperty("status_a39")]
        [JsonConverter(typeof(BoolTo39AStatusStringJsonConverter))]
        public bool IsStatus39A { get; set; }

        /// <summary>
        /// The total price
        /// </summary>
        [JsonProperty("total_price")]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// The extended attributes 
        /// </summary>
        [JsonProperty("extended_attributes")]
        public object? ExtendedAttributes { get; set; }

        /// <summary>
        /// Extra information
        /// </summary>
        [AllowNull]
        [JsonProperty("extra")]
        public OrderProductExtraResponseModel Extra
        {
            get => mExtra ??= new OrderProductExtraResponseModel();

            set => mExtra = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderProductResponseModel() : base()
        {

        }

        #endregion
    }
}
