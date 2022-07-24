using System;

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

    // STRATEGY PATTERN - It is a behavioral design pattern which helps to select algorithms on runtime
    /// For decoupling ValidationAlgorithm from MiddleLayer,
    /// we made our interface generic so that we can apply validation on any type of object
    public interface IValidation<AnyType>
    {
        void validate(AnyType obj);
    }
}
