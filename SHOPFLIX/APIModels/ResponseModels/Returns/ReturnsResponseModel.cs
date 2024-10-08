using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Represents collection of <see cref="ReturnResponseModel"/>s
    /// </summary>
    public class ReturnsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Orders"/> property
        /// </summary>
        private IEnumerable<ReturnResponseModel>? mOrders;

        #endregion

        #region Public Properties

        /// <summary>
        /// A list of the returned orders
        /// </summary>
        [AllowNull]
        [JsonProperty("orders")]
        public IEnumerable<ReturnResponseModel> Orders
        {
            get => mOrders ?? Enumerable.Empty<ReturnResponseModel>();

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
