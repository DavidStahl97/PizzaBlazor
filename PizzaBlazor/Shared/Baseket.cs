using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public record Baseket
    {
        public Customer Customer { get; init; }

        public List<int> Orders { get; set; } = new List<int>();

        public bool HasPaid { get; init; }
    }
}
