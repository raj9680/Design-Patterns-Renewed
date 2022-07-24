using Microsoft.Practices.Unity;
using MiddleLayer;
using InterfaceCustomer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static IUnityContainer custs = null;
        public static ICustomer Create(string TypeCust)
        {
            if (custs == null)
            {
                custs = new UnityContainer();
                //custs.RegisterType<ICustomer, Customer>("Customer");
                //custs.RegisterType<ICustomer, Lead>("Lead");

                custs.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerValidationAll()));
                custs.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
            }

            return custs.Resolve<ICustomer>(TypeCust);
        }
    }
}
