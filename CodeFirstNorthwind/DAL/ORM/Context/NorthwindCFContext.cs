using CodeFirstNorthwind.DAL.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNorthwind.DAL.ORM.Context
{
    public class NorthwindCFContext:DbContext
    {
        public NorthwindCFContext()
        {
            Database.Connection.ConnectionString = @"server=.;database = NorthwindCF; Integrated Security=True";         
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
