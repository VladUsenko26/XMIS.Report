// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionBase.cs" company="">
//   
// </copyright>
// <summary>
//   Base class for custom exceptions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Common.Exception
{
    using System;
    using System.Collections;

    /// <summary>
    /// The exception base.
    /// </summary>
    public class ExceptionBase : ApplicationException
    {
        /// <summary>
        /// The exception message.
        /// </summary>
        protected string exceptionMessage = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionBase"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public ExceptionBase(string message)
            : base(message)
        {
            this.SetExceptionMessage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionBase"/> class.
        /// </summary>
        public ExceptionBase()
        {
            this.SetExceptionMessage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionBase"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="innerException">
        /// The inner exception.
        /// </param>
        public ExceptionBase(string message, Exception innerException)
            : base(message, innerException)
        {
            this.SetExceptionMessage();
        }

        /// <summary>
        /// The get message.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetMessage()
        {
            var result = this.AddDetails(this.exceptionMessage);
            result = string.Format("{0} - {1}", result, this.Message);
            return result;
        }

        /// <summary>
        /// The set exception message.
        /// </summary>
        protected virtual void SetExceptionMessage()
        {
        }

        /// <summary>
        /// The add details.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string AddDetails(string message)
        {
            var messageResult = message;
            foreach (DictionaryEntry dictionaryEntry in this.Data)
            {
                messageResult = messageResult.Replace(
                    "[" + dictionaryEntry.Key + "]", 
                    "[" + dictionaryEntry.Value + "]");
            }

            return messageResult;
        }
    }
}