using System;

namespace MiddleLayer
{
    // Common Domain
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        // Virtual
        public virtual void Validate()
        {
            throw new Exception("Not implemented");
        }
    }

    // Customer Domain
    public class Customer: CustomerBase
    {
        // overidden virtual
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
            if(BillAmount == 0)
            {
                throw new Exception("Bill amount cannot be 0");
            }
            if(BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date is not proper");
            }
            if(Address.Length == 0)
            {
                throw new Exception("Address is required");
            }
        }
    }

    // Lead Domain
    public class Lead: CustomerBase
    {
        // overidden virtual
        public override void Validate()
        {
            if(CustomerName.Length == 0)
            {
                throw new Exception("Lead name is required");
            }
            if(PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}
