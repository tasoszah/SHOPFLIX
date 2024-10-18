using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// Contains information related to a message
    /// </summary>
    public class MessageResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The message
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get => mMessage ?? string.Empty;

            set => mMessage = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageResponseModel() : base()
        {

        }

        #endregion
    }
}
