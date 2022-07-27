using CommonDAL;
using InterfaceCustomer;
using System.Collections.Generic;
using System.Data.SqlClient;
using FactoryCustomer;
using System;

/// Template Pattern
namespace AdoDotnetDAL /// Sequence of ADO.NET - OpenConnection -> ExecuteQuery -> CloseConnection
{
    public abstract class TemplateADO<AnyType> : AbstractDal<AnyType>
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


        protected abstract void ExecuteCommand(AnyType obj);  // (Add records) To force child class to override this method
        protected abstract List<AnyType> ExecuteCommand();  // (Get records) To force child class to override this method

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

        public List<AnyType> Execute()
        {
            List<AnyType> objTypes = null;
            Open();
            objTypes = ExecuteCommand();
            Close();
            return objTypes;
        }


        // Interface inherited/override methods
        public override void Save()
        {
            foreach (AnyType o in AnyTypes) /// AnyTypes coming from AnstractDal
            {
                Execute(o);
            }
        }

        public override List<AnyType> Search()
        {
            return Execute();
        }
    }


    /// Actual DAL above was template pattern design for fixed sequence
    public class CustomerDAL : TemplateADO<ICustomer>
    {
        public CustomerDAL(string _ConnectionString) : base(_ConnectionString)
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


        protected override List<ICustomer> ExecuteCommand()
        {
            objCommand.CommandText = "SELECT * FROM tblCustomer";
            SqlDataReader dr = null;
            dr = objCommand.ExecuteReader();
            List<ICustomer> custs = new List<ICustomer>();
            while (dr.Read())
            {
                ICustomer icust = Factory<ICustomer>.Create("Customer");
                icust.CustomerName = dr["CustomerName"].ToString();
                icust.BillDate = Convert.ToDateTime(dr["BillDate"]);
                icust.BillAmount = Convert.ToDecimal(dr["BillAmount"]);
                icust.PhoneNumber = dr["PhoneNumber"].ToString();
                icust.Address = dr["Address"].ToString();
                custs.Add(icust);
            }
            return custs;
        }

    }
}
