using System;
using System.ComponentModel.DataAnnotations;

namespace InterfaceCustomer
{
    public interface ICustomer
    {
        // added Id as EF required Id.
        public int Id { get; set; }
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }
        void Validate();
    }

    // Took from MiddleLayer.cass1.cs & converted to abstract class as we can only map abstract to ef
    //public abstract class CustomerBase : ICustomer - removed abstract as we cannot make obj of abstract class and ef from factoryDal not able to create class
    public class CustomerBase : ICustomer
    {
        /// creating object of IValidation whoever use the entities of middle layer
        private IValidation<ICustomer> validation = null;
        public CustomerBase(IValidation<ICustomer> obj)
        {
            validation = obj;
        }

        [Key]
        public int Id { get; set; }
        public string CustomerType { get; set; }
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

    /// STRATEGY PATTERN
    public interface IValidation<AnyType>
    {
        void validate(AnyType obj);
    }
}
