using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public record State
    {
        public Menu Menu { get; init; }

        public Baseket Baseket { get; init; }

        public UI UI { get; init; }
    }
}
