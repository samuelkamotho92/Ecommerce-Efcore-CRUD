using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        [Column(TypeName = "decimal(18,4")]
        public decimal price { get; set; }
    }
}
