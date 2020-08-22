using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FavoriteToppings
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("pizzas.json");

            var pizzas = JsonSerializer.Deserialize<List<Pizza>>(json);

            var twoToppingPizzas = pizzas.Where(p => p.toppings.Count == 2);

        }
    }


    public class Pizza    {
        public List<string> toppings { get; set; } 
    }
}
