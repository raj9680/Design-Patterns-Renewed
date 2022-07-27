using Microsoft.Practices.Unity;
using AdoDotnetDAL;
using InterfaceDal;
using InterfaceCustomer;
/// for repo-temp pattern
/// end

namespace FactoryDal
{
    // ICustomer got replaced with AnyType
    public static class FactoryClass<AnyType>
    {
        private static IUnityContainer ObjectsOfOurProjects = null;
        public static AnyType Create(string Type)
        {
            if (ObjectsOfOurProjects == null)
            {
                ObjectsOfOurProjects = new UnityContainer();

                // Objct creation of Repo-Temp pattern - Object of DAL
                ObjectsOfOurProjects.RegisterType<IDal<ICustomer>, CustomerDAL>("ADODal");
            }

            //return ObjectsOfOurProjects.Resolve<AnyType>(Type);
            return ObjectsOfOurProjects.Resolve<AnyType>(Type,
                new ResolverOverride[] {
                    new ParameterOverride("_ConnectionString", @"Data Source=.; 
                                                                Initial Catalog=CustomerDB(DesignPattern); 
                                                                Integrated Security=True;")
                });
        }
    }
}
