using InterfaceCustomer;
using System;

namespace ValidationAlgorithms
{
    public class CustomerValidationAll : IValidation<ICustomer>
    {
        public void validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (obj.BillAmount == 0)
            {
                throw new Exception("Bill amount cannot be 0");
            }
            if (obj.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date is not proper");
            }
            if (obj.Address.Length == 0)
            {
                throw new Exception("Address is required");
            }
        }
    }

    public class LeadValidation : IValidation<ICustomer>
    {
        public void validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Lead name is required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}
