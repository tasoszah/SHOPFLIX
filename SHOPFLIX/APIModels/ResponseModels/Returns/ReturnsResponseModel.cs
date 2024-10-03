using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        #region Public Properties

        /// <summary>
        /// A list of the returned orders
        /// </summary>
        [JsonProperty("orders")]
        public List<ReturnResponseModel> Orders { get; set; }

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
