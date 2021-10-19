using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Salad : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == SaladEnm.Agkourontomata.ToString())
                return this.Price = 2m * Quantity;
            else if (this.Name == SaladEnm.Xoriatiki.ToString() || this.Name == SaladEnm.Maroulosalata.ToString())
                return this.Price = 2.5m * Quantity;
            else if (this.Name == SaladEnm.Cesars.ToString() || this.Name == SaladEnm.Cefs.ToString())
                return this.Price = 4.5m * Quantity;
            else
                return Price = 0m;
        }
    }
}
