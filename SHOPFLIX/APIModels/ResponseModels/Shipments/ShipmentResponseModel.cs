using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a shipment
    /// </summary>
    public class ShipmentResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The shipment id
        /// </summary>
        [JsonProperty("shipment_id")]
        public int ShipmentId { get; set; }

        /// <summary>
        /// The shipment timestamp
        /// </summary>
        [JsonProperty("shipment_timestamp")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimeIntegerJsonConverter))]
        public DateTimeOffset ShipmentTimestamp { get; set; }

        /// <summary>
        ///The comments
        /// </summary>
        [JsonProperty("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// The shipment status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(ShipmentStatusToStringJsonConverter))]
        public ShipmentStatus Status { get; set; }

        /// <summary>
        /// The order id
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// The order timestamp
        /// </summary>
        [JsonProperty("order_timestamp")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimeIntegerJsonConverter))]
        public DateTimeOffset OrderTimestamp { get; set; }

        /// <summary>
        /// The shipment first name
        /// </summary>
        [JsonProperty("s_firstname")]
        public string SFirstname { get; set; }

        /// <summary>
        /// The shipment last name
        /// </summary>
        [JsonProperty("s_lastname")]
        public string SLastname { get; set; }

        /// <summary>
        /// The billing first name
        /// </summary>
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// The billing last name
        /// </summary>
        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// The company name
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The customer's id
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The shipping id
        /// </summary>
        [JsonProperty("shipping_id")]
        public int ShippingId { get; set; }

        /// <summary>
        /// The shipping method
        /// </summary>
        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        /// <summary>
        /// The tracking number
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
        
        /// <summary>
        /// The carrier name
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// The funship charge type
        /// </summary>
        [JsonProperty("funship_charge_type")]
        public string FunshipChargeType { get; set; }

        /// <summary>
        /// The funship shipment status
        /// </summary>
        [JsonProperty("funship_shipment_status")]
        public string FunshipShipmentStatus { get; set; }

        /// <summary>
        /// The shipping cost
        /// </summary>
        [JsonProperty("shipping_cost")]
        public decimal ShippingCost { get; set; }

        /// <summary>
        /// The cod cost
        /// </summary>
        [JsonProperty("cod_cost")]
        public decimal CodCost { get; set; }

        /// <summary>
        /// The products of the shipment
        /// </summary>
        [JsonProperty("products")]
        public object Products { get; set; }

        /// <summary>
        /// The group key
        /// </summary>
        [JsonProperty("group_key")]
        public int GroupKey { get; set; }

        /// <summary>
        /// The information about the products
        /// </summary>
        [JsonProperty("products_info")]
        public object ProductsInfo { get; set; }

        /// <summary>
        /// The carrier info
        /// </summary>
        [JsonProperty("carrier_info")]
        public CarrierInfoResponseModel CarrierInfo { get; set; }

        /// <summary>
        /// A flag that indicates if its full or not
        /// </summary>
        [JsonProperty("one_full")]
        public bool IsOneFull { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentResponseModel() : base()
        {

        }

        #endregion

    }
}
