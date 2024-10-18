using Newtonsoft.Json;
using System;

namespace SHOPFLIX
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="string"/> to a <see cref="bool"/>
    /// </summary>
    public abstract class BaseBoolToStringJsonConverter : JsonConverter<bool>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseBoolToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override sealed bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            => serializer.Deserialize<string>(reader) == GetTrueString();

        /// <inheritdoc/>
        public override sealed void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            => writer.WriteValue(value ? GetTrueString() : GetFalseString());

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the string representation for the <see cref="true"/> value
        /// </summary>
        /// <returns></returns>
        protected abstract string GetTrueString();

        /// <summary>
        /// Gets the string representation for the <see cref="false"/> value
        /// </summary>
        /// <returns></returns>
        protected abstract string GetFalseString();

        #endregion
    }
}
