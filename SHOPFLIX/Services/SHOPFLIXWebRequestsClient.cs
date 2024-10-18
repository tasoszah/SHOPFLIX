using System;
using System.Net.Http.Headers;
using System.Text;

namespace SHOPFLIX
{
    /// <summary>
    /// An implementation of the <see cref="WebRequestResult{TResult}"/> that uses a set of <see cref="SHOPFLIXCredentials"/>
    /// </summary>
    public class SHOPFLIXWebRequestsClient : WebRequestsClient<SHOPFLIXCredentials>
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Instance"/>
        /// </summary>
        private static readonly Lazy<SHOPFLIXWebRequestsClient> mInstance = new(() => new());

        #endregion

        #region Public Properties

        #region Singleton

        /// <summary>
        /// A single instance of the <see cref="SHOPFLIXWebRequestsClient"/>
        /// </summary>
        public static SHOPFLIXWebRequestsClient Instance => mInstance.Value;

        #endregion

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        protected SHOPFLIXWebRequestsClient() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override AuthenticationHeaderValue CreateAuthenticationHeader(SHOPFLIXCredentials authenticationArgs)
        {
            var credentials = $"{authenticationArgs.Username}:{authenticationArgs.Password}";
            var base64 = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(credentials));
            return new AuthenticationHeaderValue("Basic", base64);
        }

        #endregion
    }
}
