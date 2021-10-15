using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Bread : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == BreadEnm.Psomaki.ToString() || this.Name == BreadEnm.Pita.ToString())
                return this.Price = 0.4m;
            else if(this.Name == BreadEnm.Kypriaki.ToString())
                return this.Price = 0.6m;
            else if (this.Name == BreadEnm.Araviki.ToString() || this.Name == BreadEnm.Tortilla.ToString())
                return this.Price = 0.7m;
            else
                return Price = 0m;
        }
    }
}
