using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents the full information of a return
    /// </summary>
    public class ReturnResponseModel : MinimalReturnResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="CompanyId"/> property
        /// </summary>
        private string? mCompanyId;

        /// <summary>
        /// THe member of the <see cref="SAddressType"/> property
        /// </summary>
        private string? mSAddressType;

        /// <summary>
        /// THe member of the <see cref="CompanyName"/> property
        /// </summary>
        private string? mCompanyName;

        /// <summary>
        /// THe member of the <see cref="LastOrderChange"/> property
        /// </summary>
        private string? mLastOrderChange;

        /// <summary>
        /// The member of the <see cref="ShipmentIds"/> property
        /// </summary>
        private IEnumerable<int>? mShipmentIds;

        /// <summary>
        /// The member of the <see cref="Notes"/> property
        /// </summary>
        private string? mNotes;

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
        /// The shipping zip code
        /// </summary>
        [AllowNull]
        [JsonProperty("s_address_type")]
        public string SAddressType
        {
            get => mSAddressType ?? string.Empty;

            set => mSAddressType = value;
        }

        /// <summary>
        /// The company name
        /// </summary>
        [AllowNull]
        [JsonProperty("company_name")]
        public string CompanyName
        {
            get => mCompanyName ?? string.Empty;

            set => mCompanyName = value;
        }

        /// <summary>
        /// The company ID
        /// </summary>
        [AllowNull]
        [JsonProperty("company_id")]
        public string CompanyId
        {
            get => mCompanyId ?? string.Empty;

            set => mCompanyId = value;
        }

        /// <summary>
        /// The order subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

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
        /// The fields
        /// </summary>
        [JsonProperty("fields")]
        [JsonConverter(typeof(DictionaryOfStringAndStringToObjectJsonConverter))]
        public IEnumerable<KeyValuePair<string, string>>? Fields { get; set; }

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
        /// The products of the return
        /// </summary>
        [AllowNull]
        [JsonIgnore]
        public IEnumerable<ReturnProductResponseModel> Products
        {
            get
            {
                if (ProductsInternal.IsNullOrEmpty())
                    return Enumerable.Empty<ReturnProductResponseModel>();

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

                var result = new Dictionary<string, ReturnProductResponseModel>();
                foreach (var product in value)
                    result.Add(product.Id.ToString(), product);
                ProductsInternal = result;
            }
        }

        #endregion

        #region Internal Properties

        /// <summary>
        /// An internal property used for correctly deserializing the retarded JSON structure 
        /// we have been provided
        /// </summary>
        [JsonProperty("products")]
        internal Dictionary<string, ReturnProductResponseModel>? ProductsInternal { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnResponseModel() : base()
        {

        }

        #endregion
    }
}
