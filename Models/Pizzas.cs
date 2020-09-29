using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OreganoPizzaMVC.Models
{
    public class Pizzas
    {
        [Key] // primary id
        public int PizzaId { get; set; }
        // Pizza's Name
        public string PizzaName { get; set; }
        // Price of the pizza
        public double Price { get; set; }
    }
}
