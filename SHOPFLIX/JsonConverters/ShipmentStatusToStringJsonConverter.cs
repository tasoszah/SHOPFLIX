using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting an <see cref="ShipmentStatus"/> to a <see cref="string"/>
    /// </summary>
    internal class ShipmentStatusToStringJsonConverter : BaseEnumToStringJsonConverter<ShipmentStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentStatusToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override Dictionary<ShipmentStatus, string> GetMapper()
        {
            return SHOPFLIXConstants.ShipmentStatusToStringMapper;
        }

        #endregion

    }
}
