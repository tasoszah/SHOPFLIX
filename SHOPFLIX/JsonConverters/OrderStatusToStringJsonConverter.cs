using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SHOPFLIX
{
    public class OrderStatusToStringJsonConverter : BaseEnumToStringJsonConverter<OrderStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderStatusToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override Dictionary<OrderStatus, string> GetMapper()
        {
            return SHOPFLIXConstants.OrderStatusToStringMapper;
        }

        #endregion
    }
}
