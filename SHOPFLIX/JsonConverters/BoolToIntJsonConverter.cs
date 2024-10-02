using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting a <see cref="bool"/> to an <see cref="int"/>
    /// </summary>
    public class BoolToIntJsonConverter : JsonConverter<bool>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BoolToIntJsonConverter()
        { }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<int>(reader) == 0 ? false : true;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            writer.WriteValue(value ? 1 : 0);
        }

        #endregion
    }
}
