using System;
using Microsoft.EntityFrameworkCore;
using PizzaMama.Models;

namespace PizzaMama.Data
{
    public class DataContext : DbContext
    {
        //DbSet correspond à une collection de "Pizza" 
        public DbSet<Pizza> Pizzas { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}

