using Microsoft.EntityFrameworkCore;
using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Server
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options)
            : base(options) { }

        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var pizzaEntity = modelBuilder.Entity<Pizza>();
            pizzaEntity.HasKey(x => x.Id);
            pizzaEntity.Property(x => x.Price).HasColumnType("money");
        }
    }
}
