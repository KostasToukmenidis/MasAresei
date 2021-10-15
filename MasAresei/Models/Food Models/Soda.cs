using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Soda : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == SodaEnm.Pepsi.ToString()
                || this.Name == SodaEnm.Portokalada.ToString()
                || this.Name == SodaEnm.Lemonada.ToString()
                || this.Name == SodaEnm.Sprite.ToString())
                return this.Price = 1.2m;
            else
                return Price = 0m;
        }
    }
}
