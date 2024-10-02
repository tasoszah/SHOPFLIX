using Newtonsoft.Json;
using System;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting an <see cref="int"/> that represents a UNIX timestamp in seconds to a <see cref="DateTimeOffset"/>
    /// </summary>
    public class DateTimeOffsetToUnixTimeIntegerJsonConverter : JsonConverter<DateTimeOffset>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateTimeOffsetToUnixTimeIntegerJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateTimeOffset ReadJson(JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<int>(reader);

            return DateTimeOffset.FromUnixTimeSeconds(value);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToUnixTimeSeconds());
        }

        #endregion
    }
}
