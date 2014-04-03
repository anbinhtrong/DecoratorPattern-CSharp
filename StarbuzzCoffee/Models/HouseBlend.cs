using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarbuzzCoffee.Models
{
    public sealed class HouseBlend: Beverage
    {        
        public HouseBlend()
        {
            Description = "House Blend";
            Cost = .89;
        }
    }
}
