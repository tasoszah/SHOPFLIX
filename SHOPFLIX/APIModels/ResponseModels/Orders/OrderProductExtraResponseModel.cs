using Newtonsoft.Json;
using System;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents extra information related to a product
    /// </summary>
    public class OrderProductExtraResponseModel
    {
        #region Public Properties

        /// <summary>
        /// A flag that indicates if there is a gift wrap or not
        /// </summary>
        [JsonProperty("gift_wrapper")]
        public bool IsGiftWrap { get; set; }

        /// <summary>
        /// The delivery date
        /// </summary>
        [JsonProperty("delivery_date")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly DeliveryDate { get; set; }

        /// <summary>
        /// The pickup date
        /// </summary>
        [JsonProperty("pickup_date")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly PickupDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderProductExtraResponseModel() : base()
        {

        }

        #endregion
    }
}
