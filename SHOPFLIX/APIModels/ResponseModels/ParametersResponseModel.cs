using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents a set of parameters
    /// </summary>
    public class ParametersResponseModel
    {
        #region Public Properties

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("ajax_custom")]
        public int AjaxCustom { get; set; }

        [JsonProperty("include_incompleted")]
        public bool IncludeIncompleted { get; set; }

        [JsonProperty("sort_by")]
        public string SortBy { get; set; }

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
