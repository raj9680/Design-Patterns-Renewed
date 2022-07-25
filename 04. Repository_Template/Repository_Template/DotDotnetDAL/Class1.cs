using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CommonDAL;
using InterfaceDal;
using InterfaceCustomer;

/// Template Pattern
namespace AdoDotnetDAL /// Sequence of ADO.NET - OpenConnection -> ExecuteQuery -> CloseConnection
{
    public abstract class TemplateADO<AnyType>: AbstractDal<AnyType>
    {
        protected SqlConnection objConn = null;
        protected SqlCommand objCommand = null;

        // Constructor
        public TemplateADO(string _ConnectionString)
            : base(_ConnectionString)
        {
            
        }


        private void Open()  // Fixed sequence
        {
            objConn = new SqlConnection(ConnectionString);
            objConn.Open();
            objCommand = new SqlCommand();
            objCommand.Connection = objConn;
        }


        protected abstract void ExecuteCommand(AnyType obj);  // To force child class to override this method

        private void Close()  // Fixed sequence
        {
            objConn.Close();
        }


        // Design Pattern :- Template Pattern
        public void Execute(AnyType obj)
        {
            Open();
            ExecuteCommand(obj);
            Close();
        }


        // Interface inherited/override methods
        public override void Save()
        {
            foreach (AnyType o in AnyTypes) /// AnyTypes coming from AnstractDal
            {
                Execute(o);
            }
        }
    }


    /// Actual DAL above was template pattern design for fixed sequence
    public class CustomerDAL : TemplateADO<ICustomer>
    {
        public CustomerDAL(string _ConnectionString): base(_ConnectionString)
        {

        }

        protected override void ExecuteCommand(ICustomer obj)
        {
            objCommand.CommandText = "insert into tblCustomer(" +
                "CustomerName," +
                "BillAmount, BillDate," +
                "PhoneNumber, Address)" +
                "values('" + obj.CustomerName + "'," +
                obj.BillAmount + ",'" +
                obj.BillDate + "','" +
                obj.PhoneNumber + "','" +
                obj.Address + "')";
            objCommand.ExecuteNonQuery();
        }
    }

}
