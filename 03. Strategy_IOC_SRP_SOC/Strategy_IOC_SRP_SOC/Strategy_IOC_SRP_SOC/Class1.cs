using System;
using InterfaceCustomer;

namespace MiddleLayer
{
    public class CustomerBase: ICustomer
    {
        /// creating object of IValidation whoever use the entities of middle layer
        private IValidation<ICustomer> validation = null;
        public CustomerBase(IValidation<ICustomer> obj)
        {
            validation = obj;
        }

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }
        public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = DateTime.Now;
        }

        // Virtual
        public virtual void Validate()
        {
            //throw new Exception("Not implemented");
            validation.validate(this);     // this ?
        }
    }

    public class Customer: CustomerBase
    {
        /// Moved to ValidationAlgorithm to implement SOC & decoupling of MiddleLayer from Validation   - X
        /*
        public override void Validate()
        {
            // if(CustomerName.Length == 0)
            // {
            //     throw new Exception("Customer name is required");
            // }
            // if(PhoneNumber.Length == 0)
            // {
            //     throw new Exception("Phone number is required");
            // }
            // if(BillAmount == 0)
            // {
            //     throw new Exception("Bill amount cannot be 0");
            // }
            // if(BillDate >= DateTime.Now)
            // {
            //     throw new Exception("Bill date is not proper");
            // }
            // if(Address.Length == 0)
            // {
            //     throw new Exception("Address is required");
            // }
        }
        */
        public Customer(IValidation<ICustomer> obj) : base(obj)
        {

        }
    }

    
    public class Lead: CustomerBase
    {
        /// Moved to ValidationAlgorithm to implement SOC & decoupling of MiddleLayer from Validation - X
        /*
        public override void Validate()
        {
            // if(CustomerName.Length == 0)
            // {
            //     throw new Exception("Lead name is required");
            // }
            // if(PhoneNumber.Length == 0)
            // {
            //     throw new Exception("Phone number is required");
            // }
        }
        */
        public Lead(IValidation<ICustomer> obj): base(obj)
        {
            
        }
    }
}
