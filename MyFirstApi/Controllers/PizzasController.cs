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
        [HttpGet]
        public List<Pizza> GetAllPizzas()
        {
            var pizza = new Pizza { Id = 1, Size = "Medium", Toppings = new List<string> { "Pepperoni" } };
            var pizza1 = new Pizza { Id = 2, Size = "Medium", Toppings = new List<string> { "Sausage" } };
            var pizza2 = new Pizza { Id = 3, Size = "Medium", Toppings = new List<string> { "Bacon" } };

            return new List<Pizza> {pizza, pizza1, pizza2 };
        }
    }
}
