using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace SHOPFLIX
{
    /// <summary>
    /// The Shipment ids as represented in the <see cref="OrderResponseModel"/>
    /// </summary>
    public class ShipingResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member off the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The shipment ids
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? String.Empty;

            set => mName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipingResponseModel() : base()
        {

        }

        #endregion
    }
}
