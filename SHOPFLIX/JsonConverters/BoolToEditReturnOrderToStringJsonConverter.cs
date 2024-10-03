using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="bool"/> to an accept ("V") or a decline ("W") <see cref="string"/>
    /// </summary>
    public class BoolToEditReturnOrderToStringJsonConverter : JsonConverter<bool>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BoolToEditReturnOrderToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<string>(reader) == "V" ? true : false;
        }

        /// <inhertdoc/>
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            writer.WriteValue(value ? "V" : "W");
        }

        #endregion

    }
}
