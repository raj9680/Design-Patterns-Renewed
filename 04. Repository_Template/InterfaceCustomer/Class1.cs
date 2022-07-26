﻿using System;

namespace InterfaceCustomer
{
    public interface ICustomer
    {
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }
        void Validate();
    }

    // STRATEGY PATTERN
    public interface IValidation<AnyType>
    {
        void validate(AnyType obj);
    }
}
