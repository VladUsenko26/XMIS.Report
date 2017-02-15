namespace XMIS.Report.Core.Processor.OperationProcessor.OperationProcessor.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XMIS.Report.Domain.Hospitalization;

    public static class DaybedVillagerCommonOperationProcessor
    {
        public static int GetDaybedVillagerCount(
        int departmentId,
        DateTime fromDateTime,
        DateTime toDateTime,
        IList<HospitalizationBase> hospitalizationBaseCollection)
        {
            int count = 0;
            var stayCollection =
                (from h in hospitalizationBaseCollection
                 from s in h.StayList
                 where s.DepartmentInId == departmentId && s.OutDate >= fromDateTime && s.OutDate <= toDateTime
                 && h.Villager == 1
                 select s);

            foreach (StayBase stayBase in stayCollection)
            {
                // TODO реанимация = 99
                if (stayBase.DepartmentOutId == 0)
                {
                    count += (int)(stayBase.OutDate - stayBase.InDate).TotalDays + 1;
                }
                else
                {
                    count += (int)(stayBase.OutDate - stayBase.InDate).TotalDays;
                }
            }
            return count;
        }
    }
}