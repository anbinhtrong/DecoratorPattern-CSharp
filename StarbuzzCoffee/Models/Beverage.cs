using System;

namespace StarbuzzCoffee.Models
{
    public class Beverage
    {
        public virtual string Description { get; protected set; }
        public virtual Double Cost { get; protected set; }
    }
}
