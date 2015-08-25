using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleApp.UI.Models
{
    public abstract class Beverage
    {
        internal string description = "unknown beverage";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
