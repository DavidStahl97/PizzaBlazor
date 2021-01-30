using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBlazor.Shared
{
    public class Customer
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }
}
