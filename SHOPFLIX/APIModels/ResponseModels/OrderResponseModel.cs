using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public string IssuerId { get; set; }

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
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// The email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

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
        public double Total { get; set; }

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
        [JsonProperty("points")]
        public string Points { get; set; }

        /// <summary>
        /// The products of the order
        /// </summary>
        [JsonProperty("products")]
        public List<OrderProductResponseModel> Products { get; set; }

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
