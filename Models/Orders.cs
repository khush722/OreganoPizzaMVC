using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OreganoPizzaMVC.Models
{
    public class Orders
    {
        // Order Id
        // Primar Key
        [Key]
        public int OrderId { get; set; }
        // Customer NAme
        public string CustomerName { get; set; }
        // OrderDate
        public DateTime OrderDate { get; set; }
        // Total Price
        public double TotalPrice { get; set; }

    }
}
