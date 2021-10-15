using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Sauce : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == SauceEnm.Tzatziki.ToString() ||
                this.Name == SauceEnm.SosMoustardas.ToString() ||
                this.Name == SauceEnm.Ougkareza.ToString() ||
                this.Name == SauceEnm.Tyrokauteri.ToString() ||
                this.Name == SauceEnm.Xtypiti.ToString() ||
                this.Name == SauceEnm.Rosiki.ToString())
                return this.Price = 1m;
            else
                return Price = 0m;
        }
    }
}
