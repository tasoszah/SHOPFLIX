using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting an <see cref="OrderStatus"/> to a <see cref="string"/>
    /// </summary>
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
        protected override IReadOnlyDictionary<OrderStatus, string> GetMapper() 
            => SHOPFLIXConstants.OrderStatusToStringMapper;

        #endregion
    }
}
