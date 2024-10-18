using Newtonsoft.Json;
using System;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts an <see cref="int"/> to a <see cref="decimal"/>
    /// </summary>
    public class DecimalToIntJsonConverter : JsonConverter<decimal>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DecimalToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = (decimal)serializer.Deserialize<int>(reader);
            return value / 100;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
        {
            var result = (int)value * 100;
            writer.WriteValue(result);
        }

        #endregion
    }
}
