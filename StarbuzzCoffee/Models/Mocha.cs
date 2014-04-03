using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarbuzzCoffee.Models
{
    public class Mocha: CondimentDecorator
    {
        private readonly Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost
        {
            get
            {
                return .20 + _beverage.Cost;
            }
        }

        public override string Description
        {
            get
            {
                return _beverage.Description +  ", " + "Mocha";
            }
        }
    }
}
