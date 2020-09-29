using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OreganoPizzaMVC.Models
{
    public class Customers
    {
        [Key]
        public int CustId { get; set; }
        // NAme of the customer
        public string Name { get; set; }
        // Customer address
        public string CustomerAddress { get; set; }

    }
}
