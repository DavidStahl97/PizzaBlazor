using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public class Pizza
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public decimal Price { get; init; }

        public Spiciness Spiciness { get; init; }
    }
}
