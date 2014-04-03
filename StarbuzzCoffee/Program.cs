using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarbuzzCoffee.Models;

namespace StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            beverage = new Mocha(beverage);
            beverage = new SteamedMilk(beverage);
            Console.WriteLine(beverage.Description);
            Console.WriteLine(beverage.Cost);
        }
    }
}
