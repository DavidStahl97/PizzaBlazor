using Microsoft.AspNetCore.Mvc;
using PizzaBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazor.Server.Controllers
{
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaDbContext _db;

        public PizzasController(PizzaDbContext db)
        {
            _db = db;
        }

        [HttpGet("pizzas")]
        public IQueryable<Pizza> GetPizzas()
            => _db.Pizzas;

        [HttpPost("pizzas")]
        public IActionResult InsertPizza([FromBody]Pizza pizza)
        {
            _db.Pizzas.Add(pizza);
            _db.SaveChanges();
            return Created($"pizzas/{pizza.Id}", pizza);
        }
    }
}
