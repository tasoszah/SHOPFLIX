﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{ 
    /// <summary>
    /// Represents a product in a <see cref="ReturnResponseModel"/>
    /// </summary>
    public class ReturnProductResponseModel : BaseProductResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The id of the reason of return
        /// </summary>
        [JsonProperty("reason_id")]
        public int ReasonId { get; set; }

        /// <summary>
        /// The text for the reason of return
        /// </summary>
        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReturnProductResponseModel() : base()
        {

        }

        #endregion
    }
}
