// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="">
//   
// </copyright>
// <summary>
//   The class 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.UAT
{
    using System;

    using NUnit.Framework;

    /// <summary>
    /// The test helper.
    /// </summary>
    public static class TestHelper
    {
        /// <summary>
        /// Checks to make sure that the input delegate throws a exception of type TException.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of exception expected.
        /// </typeparam>
        /// <param name="methodToExecute">
        /// The method to execute to generate the exception.
        /// </param>
        public static void AssertRaises<TException>(Action methodToExecute) where TException : Exception
        {
            try
            {
                methodToExecute();
            }
            catch (TException)
            {
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(
                    "Expected exception of type " + typeof(TException) + " but type of " + ex.GetType()
                    + " was thrown instead.");
            }

            Assert.Fail("Expected exception of type " + typeof(TException) + " but no exception was thrown.");
        }
    }
}