using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    public class OrderProductResponseModel : BaseProductResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Extra information
        /// </summary>
        [JsonProperty("extra")]
        public List<OrderProductExtraResponseModel> Extra { get; set; }

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
