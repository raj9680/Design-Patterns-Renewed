using System;
using InterfaceCustomer;

namespace MiddleLayer
{
    //public class CustomerBase: ICustomer - bcoz EF can only Map tables entity with abstract class atleast
    /// Moved below class to InterfaceCustomer.class1.cs
    // public class CustomerBase : ICustomer
    // {
    //    /// creating object of IValidation whoever use the entities of middle layer
    //    private IValidation<ICustomer> validation = null;
    //    public CustomerBase(IValidation<ICustomer> obj)
    //    {
    //        validation = obj;
    //    }

    //    public string CustomerName { get; set; }
    //    public string PhoneNumber { get; set; }
    //    public decimal BillAmount { get; set; }
    //    public DateTime BillDate { get; set; }
    //    public string Address { get; set; }
    //    public CustomerBase()
    //    {
    //        CustomerName = "";
    //        PhoneNumber = "";
    //        BillAmount = 0;
    //        BillDate = DateTime.Now;
    //    }

    //    // Virtual
    //    public virtual void Validate()
    //    {
    //        validation.validate(this);
    //    }
    //}

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

        // created parameterless ctor bcoz of Ef mapping from EfDal i.e when mapping obj from efDal
        // has value customer/lead it calling parameterless ctor bcoz it doesnt know abt paramer ctor.
        //public Customer()
        //{
        //    CustomerType = "Customer";
        //}
        public Customer(IValidation<ICustomer> obj) : base(obj)
        {
            CustomerType = "Customer";
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

        // created parameterless ctor bcoz of Ef mapping from EfDal i.e when mapping obj from efDal
        // has value customer/lead it calling parameterless ctor bcoz it doesnt know abt paramer ctor.
        //public Lead()
        //{
        //    CustomerType = "Lead";
        //}
        public Lead(IValidation<ICustomer> obj): base(obj)
        {
            CustomerType = "Lead";
        }
    }
}
