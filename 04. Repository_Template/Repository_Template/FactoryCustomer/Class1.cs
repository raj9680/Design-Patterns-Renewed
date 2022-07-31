using InterfaceCustomer;
using Microsoft.Practices.Unity;
using MiddleLayer;
using ValidationAlgorithms;
using InterfaceDal;

namespace FactoryCustomer
{
    // ICustomer got replaced with AnyType
    public static class Factory<AnyType>
    {
        private static IUnityContainer ObjectsOfOurProj = null;
        public static AnyType Create(string Type)
        {
            if (ObjectsOfOurProj == null)
            {
                ObjectsOfOurProj = new UnityContainer();
                ObjectsOfOurProj.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerValidationAll()));
                ObjectsOfOurProj.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));

                // Objct creation of Repo-Temp pattern - Object of DAL  -> FactoryDAL bcoz of circular dependency
                // ObjectsOfOurProj.RegisterType<IDal<ICustomer>, CustomerDAL>("AdoDal");
            }

            return ObjectsOfOurProj.Resolve<AnyType>(Type);

            //// -> FactoryDAL bcoz of circular dependency
            //return ObjectsOfOurProj.Resolve<AnyType>(Type,
            //    new ResolverOverride[] {
            //        new ParameterOverride("_ConnectionString", @"Data Source=.; 
            //                                                    Initial Catalog=CustomerDB(DesignPattern); 
            //                                                    Integrated Security=True;")
            //    });
        }
    }
}
