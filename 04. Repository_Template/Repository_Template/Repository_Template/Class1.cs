using System;
using InterfaceCustomer;

namespace MiddleLayer
{
    //public class CustomerBase: ICustomer - bcoz EF can only Map tables entity with abstract class atleast
    public abstract class CustomerBase : ICustomer
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
            validation.validate(this);
        }
    }

    public class Customer: CustomerBase
    {
        /// Moved to ValidationAlgorithm to implement SOC & decoupling of MiddleLayer from Validation   - X
        /*
        public override void Validate()
        {
            if(CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required");
            }
            if(PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
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
            if(CustomerName.Length == 0)
            {
                throw new Exception("Lead name is required");
            }
        }
        */
        public Lead(IValidation<ICustomer> obj): base(obj)
        {
            
        }
    }
}
