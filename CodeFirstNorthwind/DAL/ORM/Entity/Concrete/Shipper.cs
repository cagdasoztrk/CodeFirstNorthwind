using CodeFirstNorthwind.DAL.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNorthwind.DAL.ORM.Entity.Concrete
{
    public class Shipper:BaseEntity
    {
        [Key]
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}