using SHOPFLIX.APIArgs;

namespace SHOPFLIX
{
    /// <summary>
    /// Arguments used for retrieving returns
    /// </summary>
    public class ReturnAPIArgs : BaseDateBasedAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Limit the result set to entries with specific status
        /// </summary>
        public ReturnStatus? Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnAPIArgs() : base()
        {

        }

        #endregion
    }
}
