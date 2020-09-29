using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OreganoPizzaMVC.Models;

namespace OreganoPizzaMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OreganoPizzaMVC.Models.Pizzas> Pizzas { get; set; }
        public DbSet<OreganoPizzaMVC.Models.Customers> Customers { get; set; }
        public DbSet<OreganoPizzaMVC.Models.Orders> Orders { get; set; }
    }
}
