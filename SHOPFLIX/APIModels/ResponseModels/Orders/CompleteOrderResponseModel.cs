using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the full information of a single order 
    /// </summary>
    public class CompleteOrderResponseModel : OrderResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The customer's IP address 
        /// </summary>
        [JsonProperty("ip_address")]
        public string IPAddress { get; set; }

        /// <summary>
        /// The code of the language which the customer selected when placing the order, for example el 
        /// </summary>
        [JsonProperty("lang_code")]
        public string LangCode { get; set; }

        /// <summary>
        /// ID of the localization. Note: Localizations are deprecated and disabled by default.
        /// </summary>
        [JsonProperty("localization_id")]
        public int LocalizationId { get; set; }
        
        /// <summary>
        /// The total discount
        /// </summary>
        [JsonProperty("discount")]
        public double Discount { get; set; }

        /// <summary>
        /// The order subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        /// <summary>
        /// The discount on the order subtotal
        /// </summary>
        [JsonProperty("subtotal_discount")]
        public double SubtotalDiscount { get; set; }

        /// <summary>
        /// The subtotal that will be displayed
        /// </summary>
        [JsonProperty("display_subtotal")]
        public double DisplaySubtotal { get; set; }

        /// <summary>
        /// The id of the payment method
        /// </summary>
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        /// <summary>
        /// Payment information
        /// </summary>
        [JsonProperty("payment_info")]
        public object PaymentInfo { get; set; }

        /// <summary>
        /// The settings of the payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public object PaymentMethod { get; set; }

        /// <summary>
        /// The amount of payment surcharge
        /// </summary>
        [JsonProperty("payment_surcharge")]
        public double PaymentSurcharge { get; set; }

        /// <summary>
        /// Indicates if the order was repaid
        /// </summary>
        [JsonProperty("repaid")]
        [JsonConverter(typeof(BoolToIntJsonConverter))]
        public bool WasRepaid { get; set; }

        /// <summary>
        /// A string of promotion IDs separated by commas
        /// </summary>
        [JsonProperty("promotion_ids")]
        public string PromotionIds { get; set; }

        /// <summary>
        /// The data of applicable promotions
        /// </summary>
        [JsonProperty("promotions")]
        public object Promotions { get; set;}

        /// <summary>
        /// Defines if the order requires shipping
        /// </summary>
        [JsonProperty("need_shipping")]
        public bool IsShippingRequired { get; set; }

        /// <summary>
        /// The IDs of the shipping methods
        /// </summary>
        [JsonProperty("shipping_ids")]
        public string ShippingIds { get; set; }

        /// <summary>
        /// The data of the shipping methods used in the order.
        /// </summary>
        [JsonProperty("shipping")]
        public double Shipping { get; set; }

        /// <summary>
        /// The ID of the shipping method 
        /// </summary>
        [JsonProperty("shipping_id")]
        public int ShippingId { get; set; }

        /// <summary>
        /// Defines if the order requires shipments.
        /// </summary>
        [JsonProperty("need_shipment")]
        public bool IsShipmentRequired { get; set; }

        /// <summary>
        /// A string of shipment IDs separated by commas.
        /// </summary>
        [JsonProperty("shipment_ids")]
        public string ShipmentIds { get; set; }

        /// <summary>
        /// The shipping cost
        /// </summary>
        [JsonProperty("shipping_cost")]
        public double ShippingCost { get; set; }

        /// <summary>
        /// The shipping cost that will be displayed
        /// </summary>
        [JsonProperty("display_shipping_cost")]
        public double DisplayShippingCost { get; set; }

        /// <summary>
        /// Determines if the customer is exempt from taxes
        /// </summary>
        [JsonProperty("tax_exempt")]
        [JsonConverter(typeof(BoolToStringJsonConverter))]
        public bool IsTaxExempt { get; set; }

        /// <summary>
        /// The subtotal of the tax
        /// </summary>
        [JsonProperty("tax_subtotal")]
        public double TaxSubtotal { get; set; }

        /// <summary>
        /// The data of the applicable taxes
        /// </summary>
        [JsonProperty("taxes")]
        public object Taxes { get; set; }

        /// <summary>
        /// Customer’s notes about the order
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Administrator’s notes about the order
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// The shipping address
        /// </summary>
        [JsonProperty("s_address")]
        public string SAddress { get; set; }

        /// <summary>
        /// The second shipping address
        /// </summary>
        [JsonProperty("s_address_2")]
        public string SAddress2 { get; set; }

        /// <summary>
        /// The shipping city
        /// </summary>
        [JsonProperty("s_city")]
        public string SCity { get; set; }

        /// <summary>
        /// The 2-letter shipping country code
        /// </summary>
        [JsonProperty("s_country")]
        public string SCountry { get; set; }

        /// <summary>
        /// The country name
        /// </summary>
        [JsonProperty("s_country_descr")]
        public string SCountryDescr { get; set; }

        /// <summary>
        /// The shipping first name
        /// </summary>
        [JsonProperty("s_firstname")]
        public string SFirstName { get; set; }

        /// <summary>
        /// The shipping last name
        /// </summary>
        [JsonProperty("s_lastname")]
        public string SLastName { get; set; }

        /// <summary>
        /// The shipping phone number
        /// </summary>
        [JsonProperty("s_phone")]
        public string SPhone { get; set; }

        /// <summary>
        /// The shipping state code
        /// </summary>
        [JsonProperty("s_state")]
        public string SState { get; set; }

        /// <summary>
        /// The shipping state name
        /// </summary>
        [JsonProperty("s_state_descr")]
        public string SStateDescr { get; set; }

        /// <summary>
        /// The shipping zip code
        /// </summary>
        [JsonProperty("s_zipcode")]
        public string SZipCode { get; set; }

        /// <summary>
        /// The billing address
        /// </summary>
        [JsonProperty("b_address")]
        public string BAddress { get; set; }

        /// <summary>
        /// The second billing address
        /// </summary>
        [JsonProperty("b_address_2")]
        public string BAddress2 { get; set; }

        /// <summary>
        /// The billing city
        /// </summary>
        [JsonProperty("b_city")]
        public string BCity { get; set; }

        /// <summary>
        /// The 2-letter billing country code 
        /// </summary>
        [JsonProperty("b_country")]
        public string BCountry { get; set; }

        /// <summary>
        /// The billing country name
        /// </summary>
        [JsonProperty("b_country_descr")]
        public string BCountryDescr { get; set; }

        /// <summary>
        /// The billing first name
        /// </summary>
        [JsonProperty("b_firstname")]
        public string BFirstName { get; set; }

        /// <summary>
        /// The billing last name
        /// </summary>
        [JsonProperty("b_lastname")]
        public string BLastName { get; set; }

        /// <summary>
        /// The billing phone
        /// </summary>
        [JsonProperty("b_phone")]
        public string BPhone { get; set; }

        /// <summary>
        /// The billing state code
        /// </summary>
        [JsonProperty("b_state")]
        public string BState { get; set; }

        /// <summary>
        /// The billing state name
        /// </summary>
        [JsonProperty("b_state_descr")]
        public string BStateDescr { get; set; }

        /// <summary>
        /// The billing zip code
        /// </summary>
        [JsonProperty("b_zipcode")]
        public string BZipCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CompleteOrderResponseModel()
        {

        }

        #endregion
    }
}
