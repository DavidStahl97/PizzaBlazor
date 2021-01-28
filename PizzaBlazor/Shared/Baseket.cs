using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public class Baseket
    {
        public Customer Customer { get; init; }

        public List<int> Orders { get; } = new List<int>();

        public bool HasPaid { get; init; }

        public void Add(int pizzaId)
        {
            Orders.Add(pizzaId);
        }

        public void RemoveAt(int index)
        {
            Orders.RemoveAt(index);
        }
    }
}
