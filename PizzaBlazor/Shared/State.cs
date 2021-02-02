using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public class State
    {
        public Menu Menu { get; set; }

        public Basket Baseket { get; } = new Basket();

        public UI UI { get; init; }

        public decimal TotalPrice => Baseket.Orders.Sum(id => Menu.GetPizza(id).Price);
    }
}
