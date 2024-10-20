﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a shipment
    /// </summary>
    public class ShipmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProductsInfo"/> property
        /// </summary>
        private IEnumerable<ShipmentsProductsInfoResponseModel>? mProductsInfo;

        /// <summary>
        /// The member of the <see cref="OrderReference"/> property
        /// </summary>
        private string? mOrderReference;

        /// <summary>
        /// The member of the <see cref="Comments"/> property
        /// </summary>
        private string? mComments;

        /// <summary>
        /// The member of the <see cref="SFirstName"/> property
        /// </summary>
        private string? mSFirstName;

        /// <summary>
        /// The member of the <see cref="SLastName"/> property
        /// </summary>
        private string? mSLastName;

        /// <summary>
        /// The member of the <see cref="FirstName"/> property
        /// </summary>
        private string? mFirstName;

        /// <summary>
        /// The member of the <see cref="LastName"/> property
        /// </summary>
        private string? mLastName;

        /// <summary>
        /// The member of the <see cref="Company"/> property
        /// </summary>
        private string? mCompany;

        /// <summary>
        /// The member of the <see cref="Shipping"/> property
        /// </summary>
        private string? mShipping;

        /// <summary>
        /// The member of the <see cref="TrackingNumber"/> property
        /// </summary>
        private string? mTrackingNumber;

        /// <summary>
        /// The member of the <see cref="Carrier"/> property
        /// </summary>
        private string? mCarrier;

        /// <summary>
        /// The member of the <see cref="FunshipChargeType"/> property
        /// </summary>
        private string? mFunshipChargeType;

        /// <summary>
        /// The member of the <see cref="FunshipShipmentStatus"/> property
        /// </summary>
        private string? mFunshipShipmentStatus;

        #endregion

        #region Public Properties

        /// <summary>
        /// The products of the order
        /// </summary>
        [AllowNull]
        [JsonIgnore]
        public IEnumerable<ShipmentProductResponseModel> Products
        {
            get
            {
                if (ProductsInternal.IsNullOrEmpty())
                    return Enumerable.Empty<ShipmentProductResponseModel>();

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

                var result = new Dictionary<string, ShipmentProductResponseModel>();
                foreach (var product in value)
                    result.Add(product.Id.ToString(), product);
                ProductsInternal = result;
            }
        }

        /// <summary>
        /// The order reference
        /// </summary>
        [AllowNull]
        [JsonProperty("order_reference")]
        private string OrderReference
        {
            get => mOrderReference ?? string.Empty;

            set => mOrderReference = value;
        }

        /// <summary>
        /// The shipment id
        /// </summary>
        [JsonProperty("shipment_id")]
        public int ShipmentId { get; set; }

        ///// <summary>
        ///// The shipment timestamp
        ///// </summary>
        //[JsonProperty("shipment_timestamp")]
        //[JsonConverter(typeof(DateTimeOffsetToUnixTimeIntegerJsonConverter))]
        //public DateTimeOffset ShipmentTimestamp { get; set; }

        /// <summary>
        ///The comments
        /// </summary>
        [AllowNull]
        [JsonProperty("comments")]
        public string Comments
        {
            get => mComments ?? string.Empty;

            set => mComments = value;
        }

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
        [AllowNull]
        [JsonProperty("s_firstname")]
        public string SFirstName
        {
            get => mSFirstName ?? string.Empty;

            set => mSFirstName = value;
        }

        /// <summary>
        /// The shipment last name
        /// </summary>
        [AllowNull]
        [JsonProperty("s_lastname")]
        public string SLastName
        {
            get => mSLastName ?? string.Empty;

            set => mSLastName = value;
        }

        /// <summary>
        /// The billing first name
        /// </summary>
        [AllowNull]
        [JsonProperty("firstname")]
        public string FirstName
        {
            get => mFirstName ?? string.Empty;

            set => mFirstName = value;
        }

        /// <summary>
        /// The billing last name
        /// </summary>
        [AllowNull]
        [JsonProperty("lastname")]
        public string LastName
        {
            get => mLastName ?? string.Empty;

            set => mLastName = value;
        }

        /// <summary>
        /// The company name
        /// </summary>
        [AllowNull]
        [JsonProperty("company")]
        public string Company
        {
            get => mCompany ?? string.Empty;

            set => mCompany = value;
        }

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
        [AllowNull]
        [JsonProperty("shipping")]
        public string Shipping
        {
            get => mShipping ?? string.Empty;

            set => mShipping = value;
        }

        /// <summary>
        /// The tracking number
        /// </summary>
        [AllowNull]
        [JsonProperty("tracking_number")]
        public string TrackingNumber
        {
            get => mTrackingNumber ?? string.Empty;

            set => mTrackingNumber = value;
        }

        /// <summary>
        /// The carrier name
        /// </summary>
        [AllowNull]
        [JsonProperty("carrier")]
        public string Carrier
        {
            get => mCarrier ?? string.Empty;

            set => mCarrier = value;
        }

        /// <summary>
        /// The funship charge type
        /// </summary>
        [AllowNull]
        [JsonProperty("funship_charge_type")]
        public string FunshipChargeType
        {
            get => mFunshipChargeType ?? string.Empty;

            set => mFunshipChargeType = value;
        }

        /// <summary>
        /// The funship shipment status
        /// </summary>
        [AllowNull]
        [JsonProperty("funship_shipment_status")]
        public string FunshipShipmentStatus
        {
            get => mFunshipShipmentStatus ?? string.Empty;

            set => mFunshipShipmentStatus = value;
        }

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
        /// The group key
        /// </summary>
        [JsonProperty("group_key")]
        public int GroupKey { get; set; }

        /// <summary>
        /// The information about the products
        /// </summary>
        [AllowNull]
        [JsonProperty("products_info")]
        public IEnumerable<ShipmentsProductsInfoResponseModel> ProductsInfo
        {
            get => mProductsInfo ?? Enumerable.Empty<ShipmentsProductsInfoResponseModel>();

            set => mProductsInfo = value;
        }

        /// <summary>
        /// The carrier info
        /// </summary>
        [JsonProperty("carrier_info")]
        public CarrierInfoResponseModel? CarrierInfo { get; set; }

        /// <summary>
        /// A flag that indicates if its full or not
        /// </summary>
        [JsonProperty("one_full")]
        public bool IsOneFull { get; set; }

        #endregion

        #region Internal Properties

        [JsonProperty("products")]
        public Dictionary<string, ShipmentProductResponseModel>? ProductsInternal { get; set; }

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
