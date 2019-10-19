using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNorthwind.DAL.ORM.Entity.Abstract
{
    public class BaseEntity
    {
        [Column(TypeName = "datetime2")]
        public DateTime? AddedDate { get; set; }
    }   
}