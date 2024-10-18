using Newtonsoft.Json;
using System;
using System.Globalization;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="string"/> to a <see cref="DateOnly"/>
    /// </summary>
    public class DateOnlyToStringJsonConverter : JsonConverter<DateOnly?>
    {
        #region Constants

        /// <summary>
        /// The format
        /// </summary>
        public const string Format = "dd/MM/yyyy";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateOnlyToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateOnly? ReadJson(JsonReader reader, Type objectType, DateOnly? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (value.IsNullOrEmpty())
                return existingValue;

            return DateOnly.ParseExact(value, Format, CultureInfo.InvariantCulture);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateOnly? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();

                return;
            }

            writer.WriteValue(value.Value.ToString(Format, CultureInfo.InvariantCulture));
        }

        #endregion


    }
}
