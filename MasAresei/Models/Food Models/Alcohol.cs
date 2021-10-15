using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Alcohol : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == AlcoholEnm.Mpyra.ToString())
                return this.Price = 1.8m;
            else if (this.Name == AlcoholEnm.Retsina.ToString())
                return this.Price = 2m;
            else if (this.Name == AlcoholEnm.RedWhine.ToString() || this.Name == AlcoholEnm.WhiteWhine.ToString())
                return this.Price = 2.2m;
            else
                return Price = 0;
        }
    }
}
