// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DalManagerFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The dal manager factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.ConfigDataManager
{
    using System;
    using System.Configuration;

    using XMIS.Report.Core.DAL;
    using XMIS.Report.Service.Contract;

    /// <summary>
    ///     The dal manager factory.
    /// </summary>
    public static class DalManagerFactory
    {
        /*     /// <summary>
        /// Gets the config.
        /// </summary>
        public static DALManagerFactoryConfigurationSection Config { get; internal set; }

        /// <summary>
        /// The initialize.
        /// </summary>
        public static void Initialize()
        {
            Config = ConfigurationManager.GetSection("DataManager") as DALManagerFactoryConfigurationSection;
        }
*/

        /// <summary>
        ///     Gets the hospitalization data manager stub.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        private static IHospitalizationDataManager HospitalizationDataManagerStub
        {
            get
            {
                var typeName = ConfigurationManager.AppSettings["hospitalizationDataManagerStub"];
                var providerType = Type.GetType(typeName);
                if (providerType != null)
                {
                    return (IHospitalizationDataManager)Activator.CreateInstance(providerType);
                }

                throw new ArgumentNullException("HospitalizationDataManagerStub");
            }
        }

        /// <summary>
        /// Gets the hospitalization data manager.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        private static IHospitalizationDataManager HospitalizationDataManager
        {
            get
            {
                //TODO ConfigurationManager.AppSettings["hospitalizationDataManager"];
                /*     var typeName = ConfigurationManager.AppSettings["hospitalizationDataManager"];
                     var providerType = Type.GetType(typeName);
                     if (providerType != null)
                     {
                         return (IHospitalizationDataManager)Activator.CreateInstance(providerType);
                     }

                     throw new ArgumentNullException("HospitalizationDataManager"); */
                return new HospitalizationDataManager();
            }
        }

        /// <summary>
        /// The create hospitalization data manager.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="IHospitalizationDataManager"/>.
        /// </returns>
        public static IHospitalizationDataManager CreateHospitalizationDataManager(string type)
        {
            IHospitalizationDataManager hospitalizationDataManager = null;
            switch (type)
            {
                case "stub":
                    hospitalizationDataManager = HospitalizationDataManagerStub;
                    break;
                case "default":
                    hospitalizationDataManager = HospitalizationDataManager;
                    break;
                default:
                    break;
            }

            return hospitalizationDataManager;
        }
    }
}