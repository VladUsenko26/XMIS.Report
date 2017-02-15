// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvalidDataSourceException.cs" company="">
//   
// </copyright>
// <summary>
//   The invalid data source exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Common.DAL.Exception
{
    using System;

    using Common.Exception;

    /// <summary>
    /// The invalid data source exception.
    /// </summary>
    public class InvalidDataSourceException : ExceptionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDataSourceException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public InvalidDataSourceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDataSourceException"/> class.
        /// </summary>
        public InvalidDataSourceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDataSourceException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="innnerException">
        /// The innner exception.
        /// </param>
        public InvalidDataSourceException(string message, Exception innnerException)
            : base(message, innnerException)
        {
        }

        /// <summary>
        /// The set exception message.
        /// </summary>
        protected override void SetExceptionMessage()
        {
            this.exceptionMessage =
                "Attempt to get datasource: [dataSource] using connection: [connection] causes exception";
        }
    }
}