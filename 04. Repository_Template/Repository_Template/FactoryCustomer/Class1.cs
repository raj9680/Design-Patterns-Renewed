using InterfaceCustomer;
using Microsoft.Practices.Unity;
using MiddleLayer;
using ValidationAlgorithms;
/// for repo-temp pattern
using InterfaceDal;
using CommonDAL;
using AdoDotnetDAL;
/// end

namespace FactoryCustomer
{
    // ICustomer got replaced with AnyType
    public static class Factory<AnyType>
    {
        private static IUnityContainer ObjectsOfOurProjects = null;
        public static AnyType Create(string Type)
        {
            if (ObjectsOfOurProjects == null)
            {
                ObjectsOfOurProjects = new UnityContainer();
                ObjectsOfOurProjects.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerValidationAll()));
                ObjectsOfOurProjects.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));

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
