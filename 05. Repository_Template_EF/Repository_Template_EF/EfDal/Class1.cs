using InterfaceCustomer;
using InterfaceDal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EfDal
{
    public class EfDalAbstract<AnyType> : DbContext, IDal<AnyType> where AnyType : class
    {
        public EfDalAbstract()
            :base("name=Conn")
        {

        }

        // Also adapter pattern
        // Interface implementations of IDal<AnyType>
        public void Add(AnyType obj)
        {
            Set<AnyType>().Add(obj); // in memory commit
        }

        
        public List<AnyType> Search()
        {
            return Set<AnyType>().
                AsQueryable<AnyType>().
                ToList<AnyType>();
        }

        public void Save()
        {
            SaveChanges(); // physical commit
        }

        public void Update(AnyType obj)
        {
            throw new NotImplementedException();
        }
    }

    //public class EfCustmerDal: EfDalAbstract<ICustomer>  
    // changed to CustomerBase type during obj creation in factoryDal, we cannot use type of interface as interface cannot be mapped with ef
    public class EfCustmerDal : EfDalAbstract<CustomerBase>
    {
        // mappings
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // mapping code - imp. to understand
            // modelBuilder.Entity<ICustomer>().ToTable("tblCustomer"); // we are supposed to use ICustomer but used CustomerBase bcoz of mapping to EF i.e abastarct class
            modelBuilder.Entity<CustomerBase>().ToTable("tblCustomer");

            // if dont to use abstract class (see CustomerBase in InterfaceCustomer) then we need to do mapping as below ref. to middelLayer
            //modelBuilder.Entity<CustomerBase>()
            //    .Map<Customer>(m => m.Requires("CustomerType").HasValue("Customer"))
            //    .Map<Lead>(m => m.Requires("CustomerType").HasValue("Lead"));

            modelBuilder.Entity<CustomerBase>().Ignore(t => t.CustomerType);


        }
    }
}
