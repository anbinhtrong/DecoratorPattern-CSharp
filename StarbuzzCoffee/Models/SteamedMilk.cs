using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarbuzzCoffee.Models
{
    public class SteamedMilk: CondimentDecorator
    {
        private readonly Beverage _beverage;
        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost
        {
            get
            {
                return .10 + _beverage.Cost;
            }
        }

        public override string Description
        {
            get
            {
                return _beverage.Description +  ", " + "Steamed Milk";
            }
        }
    }
}
