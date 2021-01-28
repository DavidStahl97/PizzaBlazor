using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public class State
    {
        public Menu Menu { get; init; }

        public Baseket Baseket { get; } = new Baseket();

        public UI UI { get; init; }
    }
}
