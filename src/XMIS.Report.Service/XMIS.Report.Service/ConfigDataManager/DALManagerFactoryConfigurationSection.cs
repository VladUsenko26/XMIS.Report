// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALManagerFactoryConfigurationSection.cs" company="">
//   
// </copyright>
// <summary>
//   The dal manager factory configuration section.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Service.ConfigDataManager
{
    using System.Configuration;

    /// <summary>
    ///     The dal manager factory configuration section.
    /// </summary>
    public class DALManagerFactoryConfigurationSection : ConfigurationSection
    {
        // <summary>
        // Gets or sets the hospitalization data manager stub.
        // </summary>
        // [ConfigurationProperty("hospitalizationDataManagerStub")]
        // public IHospitalizationDataManager HospitalizationDataManagerStub
        // {
        // get
        // {
        // return (IHospitalizationDataManager)Activator.CreateInstance(Type.GetType(this["hospitalizationDataManagerStub"].ToString())); 

        // }

        // set
        // {
        // this["hospitalizationDataManagerStub"] = value;
        // }
        // }
    }
}