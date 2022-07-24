using Microsoft.Practices.Unity;
using MiddleLayer;
using InterfaceCustomer;

namespace FactoryCustomer
{
    public static class Factory
    {
        ///private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();

        // Replacing Dictionary collection with unity container/collection
        // private static IUnityContainer custs = new UnityContainer(); OR for lazy loading
        private static IUnityContainer custs = null; // we have not created object yet to use lazyloading as well
        public static ICustomer Create(string TypeCust)
        {
            /// Lazy Loading Design Pattern -> opposite of lazy loading is eager loading
            /// if(custs.Count == 0)
            /// {
            ///     custs.Add("Customer", new Customer());
            ///     custs.Add("Lead", new Lead());
            /// }

            if (custs == null)
            {
                custs = new UnityContainer();
                custs.RegisterType<ICustomer, Customer>("Customer");
                custs.RegisterType<ICustomer, Lead>("Lead");
            }

            /// RIP - Replace if with Polymorphism
            /// return custs[TypeCust];

            return custs.Resolve<ICustomer>(TypeCust);
        }
    }
}
