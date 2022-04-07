using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Shared.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }=Guid.NewGuid();

        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
