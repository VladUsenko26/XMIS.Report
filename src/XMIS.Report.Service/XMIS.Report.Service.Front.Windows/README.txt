Note that you should start the project only under admin rights.

If you get "access denied" exception while you run the service, check Service - Propertires - Local system account is checked.

If you get "System.Security.SecurityException: The source was not found, but some or all event logs could not be searched.  Inaccessible logs: Security." - it was because you weren't running your visual studio command prompt as an administrator.

C:\Windows\Microsoft.NET\Framework\v4.0.30319>InstallUtil.exe C:\XMIS.Report.Ser
vice\XMIS.Report.Service\XMIS.Report.Service.Front.Windows\bin\Debug\XMIS.Report
.Service.Front.Windows.exe