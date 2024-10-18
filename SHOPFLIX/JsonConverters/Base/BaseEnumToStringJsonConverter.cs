using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SHOPFLIX
{
    /// <summary>
    /// The base for all the <see cref="JsonConverter{T}"/>s that convert between a <typeparamref name="TEnum"/>
    /// an a <see cref="string"/>
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum</typeparam>
    public abstract class BaseEnumToStringJsonConverter<TEnum> : JsonConverter<TEnum>
        where TEnum : Enum
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override sealed TEnum? ReadJson(JsonReader reader, Type objectType, TEnum? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (string.IsNullOrWhiteSpace(value))
                return default;

            foreach (var pair in GetMapper())
                if (pair.Value == value)
                    return pair.Key;

            return default;
        }

        /// <inheritdoc/>
        public sealed override void WriteJson(JsonWriter writer, TEnum? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            writer.WriteValue(GetMapper()[value]);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets a mapper between the <typeparamref name="TEnum"/> and their related <see cref="string"/>s
        /// </summary>
        /// <returns></returns>
        protected abstract IReadOnlyDictionary<TEnum, string> GetMapper();

        #endregion
    }
}
