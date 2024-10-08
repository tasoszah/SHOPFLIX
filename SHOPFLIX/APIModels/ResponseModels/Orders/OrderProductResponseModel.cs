using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    public class OrderProductResponseModel : BaseProductResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Extra"/> property
        /// </summary>
        private IEnumerable<OrderProductExtraResponseModel>? mExtra;

        #endregion

        #region Public Properties

        /// <summary>
        /// Extra information
        /// </summary>
        [AllowNull]
        [JsonProperty("extra")]
        public IEnumerable<OrderProductExtraResponseModel> Extra
        {
            get => mExtra ?? Enumerable.Empty<OrderProductExtraResponseModel>();

            set => mExtra = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderProductResponseModel() : base()
        {

        }

        #endregion
    }
}
