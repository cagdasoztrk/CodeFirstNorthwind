using CodeFirstNorthwind.DAL.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNorthwind.DAL.ORM.Entity.Concrete
{
    public class Customer:BaseEntity,IBase
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string  ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }
        public virtual List<Order> Orders { get; set; }
        public string PostalCode { get; set; }
    }
}
