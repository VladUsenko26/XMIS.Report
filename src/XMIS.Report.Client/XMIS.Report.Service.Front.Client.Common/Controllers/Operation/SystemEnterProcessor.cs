// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemEnterProcessor.cs" company="">
//   
// </copyright>
// <summary>
//   The system enter processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.Front.Client.Common.Controllers.Operation
{
    using XMIS.Report.Client.Domain;
    using XMIS.Report.Service.Front.Client.Common.Context;

    /// <summary>
    ///     The system enter processor.
    /// </summary>
    public class SystemEnterProcessor
    {
        /// <summary>
        /// The system enter.
        /// </summary>
        /// <param name="login">
        /// The login.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// The <see cref="MemberInfo"/>.
        /// </returns>
        public MemberInfo SystemEnter(string login, string password)
        {
            MemberInfo memberInfo = null;
            var systemEnter = ServiceContext.ReportProxy.Invoke<MemberInfo>("SystemEnter", login, password);
            systemEnter.Wait();
            memberInfo = systemEnter.Result;
            return memberInfo;
        }
    }
}