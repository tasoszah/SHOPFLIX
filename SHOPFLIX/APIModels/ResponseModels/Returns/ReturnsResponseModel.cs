using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents collection of <see cref="MinimalReturnResponseModel"/>s
    /// </summary>
    public class ReturnsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Parameters"/> property
        /// </summary>
        private ParametersResponseModel? mParameters;

        /// <summary>
        /// The member of the <see cref="Orders"/> property
        /// </summary>
        private IEnumerable<MinimalReturnResponseModel>? mOrders;

        #endregion

        #region Public Properties

        /// <summary>
        /// The parameters
        /// </summary>
        [AllowNull]
        [JsonProperty("params")]
        public ParametersResponseModel Parameters
        {
            get => mParameters ??= new ParametersResponseModel();

            set => mParameters = value;
        }

        /// <summary>
        /// A list of the returned orders
        /// </summary>
        [AllowNull]
        [JsonProperty("orders")]
        public IEnumerable<MinimalReturnResponseModel> Orders
        {
            get => mOrders ?? Enumerable.Empty<MinimalReturnResponseModel>();

            set => mOrders = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnsResponseModel() : base()
        {

        }

        #endregion
    }
}
