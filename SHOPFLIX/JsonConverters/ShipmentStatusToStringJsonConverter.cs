using Newtonsoft.Json;
using System.Collections.Generic;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting an <see cref="ShipmentStatus"/> to a <see cref="string"/>
    /// </summary>
    public class ShipmentStatusToStringJsonConverter : BaseEnumToStringJsonConverter<ShipmentStatus>
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
        protected override IReadOnlyDictionary<ShipmentStatus, string> GetMapper() 
            => SHOPFLIXConstants.ShipmentStatusToStringMapper;

        #endregion
    }
}
