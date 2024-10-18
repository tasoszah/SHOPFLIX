using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the full information of an order 
    /// </summary>
    public class OrderResponseModel : MinimalOrderResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Shipping"/> property
        /// </summary>
        private ShipingResponseModel? mShipping;

        /// <summary>
        /// The member of the <see cref="OrderReference"/>
        /// </summary>
        private string? mOrderReference;

        /// <summary>
        /// THe member of the <see cref="LastOrderChange"/>
        /// </summary>
        private string? mLastOrderChange;

        /// <summary>
        /// The member of the <see cref="IPAddress"/> property
        /// </summary>
        private string? mIPAddress;

        /// <summary>
        /// The member of the <see cref="LangCode"/> property
        /// </summary>
        private string? mLangCode;

        /// <summary>
        /// The member of the <see cref="PromotionIds"/> property
        /// </summary>
        private string? mPromotionIds;

        /// <summary>
        /// The member of the <see cref="ShippingIds"/> property
        /// </summary>
        private string? mShippingIds;

        /// <summary>
        /// The member of the <see cref="ShipmentIds"/> property
        /// </summary>
        private IEnumerable<int>? mShipmentIds;

        /// <summary>
        /// The member of the <see cref="Notes"/> property
        /// </summary>
        private string? mNotes;

        /// <summary>
        /// The member of the <see cref="Details"/> property
        /// </summary>
        private string? mDetails;

        /// <summary>
        /// The member of the <see cref="SAddress"/> property
        /// </summary>
        private string? mSAddress;

        /// <summary>
        /// The member of the <see cref="SAddress2"/> property
        /// </summary>
        private string? mSAddress2;

        /// <summary>
        /// The member of the <see cref="SCity"/> property
        /// </summary>
        private string? mSCity;

        /// <summary>
        /// The member of the <see cref="SCountry"/> property
        /// </summary>
        private string? mSCountry;

        /// <summary>
        /// The member of the <see cref="SCountryDescr"/> property
        /// </summary>
        private string? mSCountryDescr;

        /// <summary>
        /// The member of the <see cref="SFirstName"/> property
        /// </summary>
        private string? mSFirstName;

        /// <summary>
        /// The member of the <see cref="SLastName"/> property
        /// </summary>
        private string? mSLastName;

        /// <summary>
        /// The member of the <see cref="SPhone"/> property
        /// </summary>
        private string? mSPhone;

        /// <summary>
        /// The member of the <see cref="SState"/> property
        /// </summary>
        private string? mSState;

        /// <summary>
        /// The member of the <see cref="SStateDescr"/> property
        /// </summary>
        private string? mSStateDescr;

        /// <summary>
        /// The member of the <see cref="SZipCode"/> property
        /// </summary>
        private string? mSZipCode;

        /// <summary>
        /// The member of the <see cref="BAddress"/> property
        /// </summary>
        private string? mBAddress;

        /// <summary>
        /// The member of the <see cref="BAddress2"/> property
        /// </summary>
        private string? mBAddress2;

        /// <summary>
        /// The member of the <see cref="BCity"/> property
        /// </summary>
        private string? mBCity;

        /// <summary>
        /// The member of the <see cref="BCountry"/> property
        /// </summary>
        private string? mBCountry;

        /// <summary>
        /// The member of the <see cref="BCountryDescr"/> property
        /// </summary>
        private string? mBCountryDescr;

        /// <summary>
        /// The member of the <see cref="BFirstName"/> property
        /// </summary>
        private string? mBFirstName;

        /// <summary>
        /// The member of the <see cref="BLastName"/> property
        /// </summary>
        private string? mBLastName;

        /// <summary>
        /// The member of the <see cref="BPhone"/> property
        /// </summary>
        private string? mBPhone;

        /// <summary>
        /// The member of the <see cref="BState"/> property
        /// </summary>
        private string? mBState;

        /// <summary>
        /// The member of the <see cref="BStateDescr"/> property
        /// </summary>
        private string? mBStateDescr;

        /// <summary>
        /// The member of the <see cref="BZipCode"/> property
        /// </summary>
        private string? mBZipCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The products of the order
        /// </summary>
        [AllowNull]
        [JsonIgnore]
        public IEnumerable<OrderProductResponseModel> Products
        {
            get
            {
                if (ProductsInternal.IsNullOrEmpty())
                    return Enumerable.Empty<OrderProductResponseModel>();

                foreach (var pair in ProductsInternal)
                    pair.Value.Id = int.Parse(pair.Key);

                return ProductsInternal.Values;
            }

            set
            {
                if (value is null)
                {
                    ProductsInternal = null;

                    return;
                }

                var result = new Dictionary<string, OrderProductResponseModel>();
                foreach (var product in value)
                    result.Add(product.Id.ToString(), product);
                ProductsInternal = result;
            }
        }

        /// <summary>
        /// The fields
        /// </summary>
        [JsonProperty("fields")]
        [JsonConverter(typeof(DictionaryOfStringAndStringToObjectJsonConverter))]
        public IEnumerable<KeyValuePair<string, string>>? Fields { get; set; }

        /// <summary>
        /// The order reference
        /// </summary>
        [AllowNull]
        [JsonProperty("order_reference")]
        public string OrderReference
        {
            get => mOrderReference ?? string.Empty;

            set => mOrderReference = value;
        }

        /// <summary>
        /// The last change of the order
        /// </summary>
        [AllowNull]
        [JsonProperty("last_order_change")]
        public string LastOrderChange
        {
            get => mLastOrderChange ?? string.Empty;

            set => mLastOrderChange = value;
        }

        /// <summary>
        /// The customer's IP address 
        /// </summary>
        [AllowNull]
        [JsonProperty("ip_address")]
        public string IPAddress
        {
            get => mIPAddress ?? string.Empty;

            set => mIPAddress = value;
        }

        /// <summary>
        /// The code of the language which the customer selected when placing the order, for example el 
        /// </summary>
        [AllowNull]
        [JsonProperty("lang_code")]
        public string LangCode
        {
            get => mLangCode ?? string.Empty;

            set => mLangCode = value;
        }

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
        public object? PaymentInfo { get; set; }

        /// <summary>
        /// The settings of the payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public object? PaymentMethod { get; set; }

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
        [AllowNull]
        [JsonProperty("promotion_ids")]
        public string PromotionIds
        {
            get => mPromotionIds ?? string.Empty;

            set => mPromotionIds = value;
        }

        /// <summary>
        /// The data of applicable promotions
        /// </summary>
        [JsonProperty("promotions")]
        public object? Promotions { get; set; }

        /// <summary>
        /// Defines if the order requires shipping
        /// </summary>
        [JsonProperty("need_shipping")]
        public bool IsShippingRequired { get; set; }

        /// <summary>
        /// The IDs of the shipping methods
        /// </summary>
        [AllowNull]
        [JsonProperty("shipping_ids")]
        public string ShippingIds
        {
            get => mShippingIds ?? string.Empty;

            set => mShippingIds = value;
        }

        /// <summary>
        /// The data of the shipping methods used in the order.
        /// </summary>
        [AllowNull]
        [JsonProperty("shipping")]
        public ShipingResponseModel Shipping
        {
            get
            {
                if (mShipping == null)
                    mShipping = new ShipingResponseModel();

                return mShipping;
            }

            set => mShipping = value;
        }

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
        [AllowNull]
        [JsonProperty("shipment_ids")]
        public IEnumerable<int> ShipmentIds
        {
            get => mShipmentIds ?? Enumerable.Empty<int>();

            set => mShipmentIds = value;
        }

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
        public object? Taxes { get; set; }

        /// <summary>
        /// Customer’s notes about the order
        /// </summary>
        [AllowNull]
        [JsonProperty("notes")]
        public string Notes
        {
            get => mNotes ?? string.Empty;

            set => mNotes = value;
        }

        /// <summary>
        /// Administrator’s notes about the order
        /// </summary>
        [AllowNull]
        [JsonProperty("details")]
        public string Details
        {
            get => mDetails ?? string.Empty;

            set => mDetails = value;
        }

        /// <summary>
        /// The shipping address
        /// </summary>
        [AllowNull]
        [JsonProperty("s_address")]
        public string SAddress
        {
            get => mSAddress ?? string.Empty;

            set => mSAddress = value;
        }

        /// <summary>
        /// The second shipping address
        /// </summary>
        [AllowNull]
        [JsonProperty("s_address_2")]
        public string SAddress2
        {
            get => mSAddress2 ?? string.Empty;

            set => mSAddress2 = value;
        }

        /// <summary>
        /// The shipping city
        /// </summary>
        [AllowNull]
        [JsonProperty("s_city")]
        public string SCity
        {
            get => mSCity ?? string.Empty;

            set => mSCity = value;
        }

        /// <summary>
        /// The 2-letter shipping country code
        /// </summary>
        [AllowNull]
        [JsonProperty("s_country")]
        public string SCountry
        {
            get => mSCountry ?? string.Empty;

            set => mSCountry = value;
        }

        /// <summary>
        /// The country name
        /// </summary>
        [AllowNull]
        [JsonProperty("s_country_descr")]
        public string SCountryDescr
        {
            get => mSCountryDescr ?? string.Empty;

            set => mSCountryDescr = value;
        }

        /// <summary>
        /// The shipping first name
        /// </summary>
        [AllowNull]
        [JsonProperty("s_firstname")]
        public string SFirstName
        {
            get => mSFirstName ?? string.Empty;

            set => mSFirstName = value;
        }

        /// <summary>
        /// The shipping last name
        /// </summary>
        [AllowNull]
        [JsonProperty("s_lastname")]
        public string SLastName
        {
            get => mSLastName ?? string.Empty;

            set => mSLastName = value;
        }

        /// <summary>
        /// The shipping phone number
        /// </summary>
        [AllowNull]
        [JsonProperty("s_phone")]
        public string SPhone
        {
            get => mSPhone ?? string.Empty;

            set => mSPhone = value;
        }

        /// <summary>
        /// The shipping state code
        /// </summary>
        [AllowNull]
        [JsonProperty("s_state")]
        public string SState
        {
            get => mSState ?? string.Empty;

            set => mSState = value;
        }

        /// <summary>
        /// The shipping state name
        /// </summary>
        [AllowNull]
        [JsonProperty("s_state_descr")]
        public string SStateDescr
        {
            get => mSStateDescr ?? string.Empty;

            set => mSStateDescr = value;
        }

        /// <summary>
        /// The shipping zip code
        /// </summary>
        [AllowNull]
        [JsonProperty("s_zipcode")]
        public string SZipCode
        {
            get => mSZipCode ?? string.Empty;

            set => mSZipCode = value;
        }

        /// <summary>
        /// The billing address
        /// </summary>
        [AllowNull]
        [JsonProperty("b_address")]
        public string BAddress
        {
            get => mBAddress ?? string.Empty;

            set => mBAddress = value;
        }

        /// <summary>
        /// The second billing address
        /// </summary>
        [AllowNull]
        [JsonProperty("b_address_2")]
        public string BAddress2
        {
            get => mBAddress2 ?? string.Empty;

            set => mBAddress2 = value;
        }

        /// <summary>
        /// The billing city
        /// </summary>
        [AllowNull]
        [JsonProperty("b_city")]
        public string BCity
        {
            get => mBCity ?? string.Empty;

            set => mBCity = value;
        }

        /// <summary>
        /// The 2-letter billing country code 
        /// </summary>
        [AllowNull]
        [JsonProperty("b_country")]
        public string BCountry
        {
            get => mBCountry ?? string.Empty;

            set => mBCountry = value;
        }

        /// <summary>
        /// The billing country name
        /// </summary>
        [AllowNull]
        [JsonProperty("b_country_descr")]
        public string BCountryDescr
        {
            get => mBCountryDescr ?? string.Empty;

            set => mBCountryDescr = value;
        }

        /// <summary>
        /// The billing first name
        /// </summary>
        [AllowNull]
        [JsonProperty("b_firstname")]
        public string BFirstName
        {
            get => mBFirstName ?? string.Empty;

            set => mBFirstName = value;
        }

        /// <summary>
        /// The billing last name
        /// </summary>
        [AllowNull]
        [JsonProperty("b_lastname")]
        public string BLastName
        {
            get => mBLastName ?? string.Empty;

            set => mBLastName = value;
        }

        /// <summary>
        /// The billing phone
        /// </summary>
        [AllowNull]
        [JsonProperty("b_phone")]
        public string BPhone
        {
            get => mBPhone ?? string.Empty;

            set => mBPhone = value;
        }

        /// <summary>
        /// The billing state code
        /// </summary>
        [AllowNull]
        [JsonProperty("b_state")]
        public string BState
        {
            get => mBState ?? string.Empty;

            set => mBState = value;
        }

        /// <summary>
        /// The billing state name
        /// </summary>
        [AllowNull]
        [JsonProperty("b_state_descr")]
        public string BStateDescr
        {
            get => mBStateDescr ?? string.Empty;

            set => mBStateDescr = value;
        }

        /// <summary>
        /// The billing zip code
        /// </summary>
        [AllowNull]
        [JsonProperty("b_zipcode")]
        public string BZipCode
        {
            get => mBZipCode ?? string.Empty;

            set => mBZipCode = value;
        }

        #endregion

        #region Internal Properties

        /// <summary>
        /// An internal property used for correctly deserializing the retarded JSON structure 
        /// we have been provided
        /// </summary>
        [JsonProperty("products")]
        internal Dictionary<string, OrderProductResponseModel>? ProductsInternal { get; set; }

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
