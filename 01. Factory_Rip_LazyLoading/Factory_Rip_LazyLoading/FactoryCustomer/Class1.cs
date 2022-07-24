using MiddleLayer;
using System;
using System.Collections.Generic;

namespace FactoryCustomer
{
    public static class Factory // Simple Factory Pattern (Manual)
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();

        /// Constructor - XX
        // static Factory()      // It is creating object whether required or not required, which is not good.
        //                      // To make it instantiate only when required we use Lazy Loading Pattern. - XXX
        // {
        //     custs.Add("Customer", new Customer());
        //     custs.Add("Lead", new Lead());
        // }

        public static CustomerBase Create(string TypeCust)
        {
            // Lazy Loading Design Pattern -> opposite of lazy loading is eager loading
            if(custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            // Get this implementation from FrmCustomer.cs - later removed and made bcoz of multiple if using - XX
            /// if(TypeCust == "Customer")
            /// {
            ///     return new Customer();
            /// }
            /// else
            /// {
            ///     return new Lead();
            /// }
            
            // RIP - Replace if with Polymorphism
            return custs[TypeCust];
        }
    }
}
