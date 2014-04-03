using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarbuzzCoffee.Models
{
    public sealed class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
            Cost = .99;
        }
    }
}
