// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestingContext.cs" company="">
//   
// </copyright>
// <summary>
//   The testing context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.UAT.Context
{
    using XMIS.Report.Service.Front.Client.Common;
    using XMIS.Report.Service.Front.Client.Contract;

    /// <summary>
    /// The testing context.
    /// </summary>
    public class TestingContext
    {
        /// <summary>
        /// The front service client.
        /// </summary>
        public static IFrontServiceClient FrontServiceClient;

        /// <summary>
        /// Initializes static members of the <see cref="TestingContext"/> class.
        /// </summary>
        static TestingContext()
        {
            FrontServiceClient = new FrontServiceClient();
        }
    }
}