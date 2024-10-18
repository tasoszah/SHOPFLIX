using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a set of parameters
    /// </summary>
    public class ParametersResponseModel
    {
        #region Private Members

        ///// <summary>
        ///// The member of the <see cref="SortOrder"/> property
        ///// </summary>
        //private string? mSortOrder;

        ///// <summary>
        ///// The member of the <see cref="SortBy"/> property
        ///// </summary>
        //private string? mSortBy;

        ///// <summary>
        ///// The member of the <see cref="SortOrderRev"/> property
        ///// </summary>
        //private string? mSortOrderRev;

        /// <summary>
        /// The member of the <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        #endregion

        #region Public Properties


        /// <summary>
        /// The date from
        /// </summary>
        [JsonProperty("date_from")]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// The date to
        /// </summary>
        [JsonProperty("date_to")]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// The number of pages
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Shows how many items there are on a page
        /// </summary>
        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        [AllowNull]
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;

            set => mStatus = value;
        }

        ///// <summary>
        ///// Ajax custom
        ///// </summary>
        //[JsonProperty("ajax_custom")]
        //public int AjaxCustom { get; set; }

        ///// <summary>
        ///// A flag that shows if incompleted orders are included
        ///// </summary>
        //[JsonProperty("include_incompleted")]
        //public bool DoesIncludeIncompleted { get; set; }

        ///// <summary>
        ///// Shows if the order is descending or ascending
        ///// </summary>
        //[AllowNull]
        //[JsonProperty("sort_order")]
        //public string SortOrder
        //{
        //    get => mSortOrder ?? string.Empty;

        //    set => mSortOrder = value;
        //}

        ///// <summary>
        ///// How the list is sorted
        ///// </summary>
        //[AllowNull]
        //[JsonProperty("sort_by")]
        //public string SortBy
        //{
        //    get => mSortBy ?? string.Empty;

        //    set => mSortBy = value;
        //}

        ///// <summary>
        ///// The reverse of the <see cref="SortOrder"/>
        ///// </summary>
        //[AllowNull]
        //[JsonProperty("sort_order_rev")]
        //public string SortOrderRev
        //{
        //    get => mSortOrderRev ?? string.Empty;

        //    set => mSortOrderRev = value;
        //}

        /// <summary>
        /// The total number of the items in the list
        /// </summary>
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ParametersResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Page: {Page}, Items per page: {ItemsPerPage}";
        }

        #endregion
    }
}
