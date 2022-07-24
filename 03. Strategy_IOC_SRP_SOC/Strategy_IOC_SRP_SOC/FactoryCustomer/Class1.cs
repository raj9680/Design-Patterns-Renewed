using InterfaceCustomer;
using Microsoft.Practices.Unity;
using MiddleLayer;
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
                //custs.RegisterType<ICustomer, Lead>("Lead");            - XOX

                custs.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerValidationAll()));
                custs.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));

                // Note(not sure): Before(XOX) it was sending simple obj of Customer/Lead, but now it is sending obj of
                // CustomerValidaionAll/LeadValidation or may be both Customer/Lead and CustomerValidationAll/LeadValidation
            }

            return custs.Resolve<ICustomer>(TypeCust);
        }
    }
}
