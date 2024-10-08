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
    /// Represents an order
    /// </summary>
    public class OrderResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="IssuerId"/> property
        /// </summary>
        private string? mIssuerId;

        /// <summary>
        /// The member of the <see cref="FirstName"/> property
        /// </summary>
        private string? mFirstName;

        /// <summary>
        /// The member of the <see cref="LastName"/> property
        /// </summary>
        private string? mLastName;

        /// <summary>
        /// The member of the <see cref="Points"/> property
        /// </summary>
        private string? mPoints;

        /// <summary>
        /// The member of the <see cref="Products"/> property
        /// </summary>
        private IEnumerable<OrderProductResponseModel>? mProducts;

        #endregion

        #region Public Properties

        /// <summary>
        /// The order id
        /// </summary>
        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// The issuer id
        /// </summary>
        [JsonProperty("issuer_id")]
        public string IssuerId
        {
            get => mIssuerId ?? string.Empty;

            set => mIssuerId = value;
        }

        /// <summary>
        /// The user id
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// A flag indicating if its a parent order or not
        /// </summary>
        [JsonProperty("is_parent_order")]
        [JsonConverter(typeof(BoolToStringJsonConverter))]
        public bool IsParentOrder { get; set; }

        /// <summary>
        /// The parent order id
        /// </summary>
        [JsonProperty("parent_order_id")]
        public int ParentOrderId { get; set; }

        /// <summary>
        /// The company id
        /// </summary>
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// The timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeOffsetToUnixTimeIntegerJsonConverter))]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The first name
        /// </summary>
        [AllowNull]
        [JsonProperty("firstname")]
        public string FirstName
        {
            get => mFirstName ?? String.Empty;

            set => mFirstName = value;
        }

        /// <summary>
        /// The last name
        /// </summary>
        [AllowNull]
        [JsonProperty("lastname")]
        public string LastName
        {
            get => mLastName ?? String.Empty;

            set => mLastName = value;
        }

        /// <summary>
        /// The email
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// The order status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(OrderStatusToStringJsonConverter))]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// The order total
        /// </summary>
        [JsonProperty("total")]
        public decimal Total { get; set; }

        /// <summary>
        /// The invoice id
        /// </summary>
        [JsonProperty("invoice_id")]
        public int InvoiceId { get; set; }

        /// <summary>
        /// The credit memo id
        /// </summary>
        [JsonProperty("credit_memo_id")]
        public int CreditMemoId { get; set; }

        /// <summary>
        /// The points
        /// </summary>
        [AllowNull]
        [JsonProperty("points")]
        public string Points
        {
            get => mPoints ?? String.Empty;

            set => mPoints = value;
        }


        /// <summary>
        /// The products of the order
        /// </summary>
        [AllowNull]
        [JsonProperty("products")]
        public IEnumerable<OrderProductResponseModel> Products
        {
            get => mProducts ?? Enumerable.Empty<OrderProductResponseModel>();

            set => mProducts = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderResponseModel()
        {

        }

        #endregion

    }
}
