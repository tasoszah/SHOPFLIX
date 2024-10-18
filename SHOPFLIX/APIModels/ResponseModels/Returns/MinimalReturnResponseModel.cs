using Newtonsoft.Json;
using System;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the basic information of a return
    /// </summary>
    public class MinimalReturnResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ReturnOrderReference"/> property
        /// </summary>
        private string? mReturnOrderReference;

        /// <summary>
        /// The member of the <see cref="Phone"/> property
        /// </summary>
        private string? mPhone;

        /// <summary>
        /// The member of the <see cref="Email"/> property
        /// </summary>
        private string? mEmail;

        /// <summary>
        /// The member of the <see cref="FirstName"/> property
        /// </summary>
        private string? mFirstName;

        /// <summary>
        /// The member of the <see cref="LastName"/> property
        /// </summary>
        private string? mLastName;

        /// <summary>
        /// The member of the <see cref="OrderReference"/> property
        /// </summary>
        private string? mOrderReference;

        #endregion

        #region Public Properties

        /// <summary>
        /// The return order reference
        /// </summary>
        [JsonProperty("return_order_reference")]
        public string ReturnOrderReference
        {
            get => mReturnOrderReference ?? string.Empty;

            set => mReturnOrderReference = value;
        }

        /// <summary>
        /// The phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone
        {
            get => mPhone ?? string.Empty;

            set => mPhone = value;
        }

        /// <summary>
        /// The order reference
        /// </summary>
        [JsonProperty("order_reference")]
        public string OrderReference
        {
            get => mOrderReference ?? string.Empty;

            set => mOrderReference = value;
        }

        /// <summary>
        /// The last name
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName
        {
            get => mLastName ?? string.Empty;

            set => mLastName = value;
        }

        /// <summary>
        /// The first name
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName
        {
            get => mFirstName ?? string.Empty;

            set => mFirstName = value;
        }

        /// <summary>
        /// The email
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get => mEmail ?? string.Empty;

            set => mEmail = value;
        }

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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MinimalReturnResponseModel() : base()
        {

        }

        #endregion
    }
}
