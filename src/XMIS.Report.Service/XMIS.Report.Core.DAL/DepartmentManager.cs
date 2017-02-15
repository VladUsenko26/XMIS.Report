// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DepartmentManager.cs" company="">
//   
// </copyright>
// <summary>
//   The department manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region

using System.Collections.Generic;
using System.Linq;
using XMIS.Report.Core.DAL;
using XMIS.Report.Domain;

#endregion

namespace XMIS.Report.Service
{
    /// <summary>
    ///     The department manager.
    /// </summary>
    public class DepartmentManager
    {
        /// <summary>
        ///     The department collection.
        /// </summary>
        private IList<DepartmentInfo> departmentCollection;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DepartmentManager" /> class.
        /// </summary>
        public DepartmentManager()
        {
            // this.CreateDepartment();
            DepartmentDataManager departmentDataManager = new DepartmentDataManager();
            departmentCollection = departmentDataManager.GetDepartmentCollection(string.Empty);
        }

        /// <summary>
        ///     The create department.
        /// </summary>
        private void CreateDepartment()
        {
            // TODO fill departmentCollection
            departmentCollection = new List<DepartmentInfo>
            {
                new DepartmentInfo
                {
                    // TODO 0 - пришел из неоткуда! 0 - не переведен.
                    DepartmentId = 1, 
                    DepartmentName = "Хірургія", 
                    OwnerId = 1
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 2, 
                    DepartmentName = "1 хірургія", 
                    OwnerId = 1
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 3, 
                    DepartmentName = "2 хірургія", 
                    OwnerId = 1
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 4, 
                    DepartmentName = "3 хірургія", 
                    OwnerId = 1
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 5, 
                    DepartmentName = "Проктологія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 22, 
                    DepartmentName =
                        "Онкопроктологія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 23, 
                    DepartmentName =
                        "Проктолог.загал."
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 6, 
                    DepartmentName = "Вріт"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 13, 
                    DepartmentName = "Урологія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 14, 
                    DepartmentName = "Терапія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 24, 
                    DepartmentName =
                        "Пульмонологія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 25, 
                    DepartmentName =
                        "Терапія загальна"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 15, 
                    DepartmentName = "Неврологія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 8, 
                    DepartmentName =
                        "Травматологія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 17, 
                    DepartmentName = "Ортопедія"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 18, 
                    DepartmentName =
                        "Гастроентерол"
                }, 
                new DepartmentInfo
                {
                    DepartmentId = 20, 
                    DepartmentName = "Фтизіатрія"
                }
            };
        }

        /// <summary>
        ///     The get department collection.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public IList<DepartmentInfo> GetDepartmentCollection()
        {
            return departmentCollection;
        }


        /// <summary>
        /// The get department with children collection id.
        /// </summary>
        /// <returns>
        /// The <see cref="Dictionary"/>.
        /// </returns>
        public Dictionary<int, List<int>> GetDepartmentWithChildrenCollectionId()
        {
            Dictionary<int, List<int>> globalDepartmentDictionary = new Dictionary<int, List<int>>();
            foreach (DepartmentInfo departmentInfo in departmentCollection)
            {
                if (departmentInfo.DepartmentId == departmentInfo.OwnerId)
                {
                    List<int> departmentChild = new List<int>();

                    departmentChild = (from department in departmentCollection
                        where department.OwnerId == departmentInfo.DepartmentId
                        select department.DepartmentId).ToList();
                    departmentChild.Remove(departmentInfo.OwnerId);
                    if (departmentChild.Count != 0)
                    {
                        globalDepartmentDictionary.Add(departmentInfo.OwnerId, departmentChild);
                    }
                }
            }

            return globalDepartmentDictionary;
        }
    }
}