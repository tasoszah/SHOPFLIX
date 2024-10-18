using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the basic information of an order
    /// </summary>
    public class MinimalOrderResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="CompanyId"/> property
        /// </summary>
        private string? mCompanyId;

        /// <summary>
        /// The member of the <see cref="Company"/> property
        /// </summary>
        private string? mCompany;

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
        /// The company
        /// </summary>
        [AllowNull]
        [JsonProperty("company")]
        public string Company
        {
            get => mCompany ?? string.Empty;

            set => mCompany = value;
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
            get => mFirstName ?? string.Empty;

            set => mFirstName = value;
        }

        /// <summary>
        /// The last name
        /// </summary>
        [AllowNull]
        [JsonProperty("lastname")]
        public string LastName
        {
            get => mLastName ?? string.Empty;

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
        public int? InvoiceId { get; set; }

        /// <summary>
        /// The credit memo id
        /// </summary>
        [JsonProperty("credit_memo_id")]
        public int? CreditMemoId { get; set; }

        /// <summary>
        /// The points
        /// </summary>
        [JsonProperty("points")]
        public string? Points { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MinimalOrderResponseModel()
        {

        }

        #endregion

    }
}
