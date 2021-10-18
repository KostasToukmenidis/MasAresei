using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Piece : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == MeatEnm.SouvlakiXoirino.ToString() || this.Name == MeatEnm.Pantseta.ToString())
                return this.Price = 1.6m;
            else if (this.Name == MeatEnm.SouvlakiKotopoulo.ToString() || this.Name == MeatEnm.MprizolakiXoirino.ToString())
                return this.Price = 1.8m;
            else if (this.Name == MeatEnm.FiletoKotopoulo.ToString() || this.Name == MeatEnm.Mpifteki.ToString())
                return this.Price = 2m;
            else if (this.Name == MeatEnm.MpiftekiGemisto.ToString())
                return this.Price = 2.2m;
            else
                return Price = 0m;
        }
    }
}
