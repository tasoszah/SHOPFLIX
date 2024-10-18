using System;

namespace SHOPFLIX
{
    /// <summary>
    /// The base for all the query argument converters.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public abstract class BaseQueryArgumentConverter<TValue> : IQueryArgumentConverter
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseQueryArgumentConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public string Convert(Type valueType, object value) => Convert((TValue)value);

        /// <inheritdoc/>
        public abstract string Convert(TValue value);

        #endregion
    }
}
