using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers
{
    [Route("api/pizzas")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        List<Pizza> _pizzas;

        public PizzasController()
        {
            var pizza = new Pizza { Id = 1, Size = "Medium", Toppings = new List<string> { "Pepperoni" } };
            var pizza1 = new Pizza { Id = 2, Size = "Medium", Toppings = new List<string> { "Sausage" } };
            var pizza2 = new Pizza { Id = 3, Size = "Medium", Toppings = new List<string> { "Bacon" } };

            _pizzas = new List<Pizza> { pizza, pizza1, pizza2 };
        }

        [HttpGet]
        public List<Pizza> GetAllPizzas()
        {
            return _pizzas;
        }

        //api/pizzas/{id}
        //api/pizzas/2
        [HttpGet("{id}")]
        public IActionResult GetPizzaById(int id)
        {
            var result = _pizzas.SingleOrDefault(pizza => pizza.Id == id);

            if (result == null)
            {
                return NotFound($"Could not find a pizza with the id {id}");
            }

            return Ok(result);
        }
    }
}
