using Newtonsoft.Json;
using System;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="bool"/> to a 'Y/N' <see cref="string"/>
    /// </summary>
    public class BoolToStringJsonConverter : JsonConverter<bool>
    {
        #region Constructors
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public BoolToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer) 
            => serializer.Deserialize<string>(reader) == "Y";

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer) 
            => writer.WriteValue(value ? "Y" : "N");

        #endregion
    }
}
