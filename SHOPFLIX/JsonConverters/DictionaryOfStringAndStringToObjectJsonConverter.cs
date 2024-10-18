using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that attempts to convert a Json object to a <see cref="Dictionary{TKey, TValue}"/> of
    /// <see cref="string"/> and <see cref="string"/>
    /// </summary>
    public class DictionaryOfStringAndStringToObjectJsonConverter : JsonConverter<IReadOnlyDictionary<string, string>>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DictionaryOfStringAndStringToObjectJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override IReadOnlyDictionary<string, string>? ReadJson(JsonReader reader, Type objectType, IReadOnlyDictionary<string, string>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                serializer.Deserialize<object?>(reader);

                return new Dictionary<string, string>();
            }

            return serializer.Deserialize<IReadOnlyDictionary<string, string>?>(reader);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, IReadOnlyDictionary<string, string>? value, JsonSerializer serializer)
        {
            if (value.IsNullOrEmpty())
            {
                writer.WriteStartArray();
                writer.WriteEndArray();

                return;
            }

            writer.WriteStartObject();

            foreach (var item in value)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteValue(item.Value);
            }

            writer.WriteEndObject();

        }

        #endregion
    }
}
