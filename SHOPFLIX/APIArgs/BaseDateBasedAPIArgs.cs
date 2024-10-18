using System;

namespace SHOPFLIX.APIArgs
{
    /// <summary>
    /// The base for 
    /// </summary>
    public abstract class BaseDateBasedAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Limit the result set to entries created after a specific date
        /// </summary>
        [Name("date_from")]
        [QueryArgumentConverter<SHOPFLIXDateTimeQueyArgumentConverter>]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Limit the result set to entries created before a specific date
        /// </summary>
        [Name("date_to")]
        [QueryArgumentConverter<SHOPFLIXDateTimeQueyArgumentConverter>]
        public DateTime? DateTo { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDateBasedAPIArgs() : base()
        {

        }

        #endregion
    }
}
