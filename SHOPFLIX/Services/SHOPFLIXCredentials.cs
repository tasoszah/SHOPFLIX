using System;

namespace SHOPFLIX
{
    /// <summary>
    /// A set of SHOPFLIX credentials
    /// </summary>
    public record SHOPFLIXCredentials
    {
        #region Public Properties

        /// <summary>
        /// The username
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SHOPFLIXCredentials(string username, string password) : base()
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        #endregion
    }
}
