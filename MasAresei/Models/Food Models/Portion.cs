using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Portion : FoodParent, IFoodPricing
    {
        public decimal GetPrice()
        {
            if (this.Name == MeatEnm.GyrosXoirinos.ToString() || this.Name == MeatEnm.GyrosKotopoulo.ToString() || this.Name == MeatEnm.KontosouvliXoirino.ToString() || this.Name == MeatEnm.KontosouvliKotopoulo.ToString() || this.Name == MeatEnm.MpiftekiGemisto.ToString())
                return this.Price = 7.8m;
            else if (this.Name == MeatEnm.SouvlakiKotopoulo.ToString() || this.Name == MeatEnm.MprizolakiXoirino.ToString() || this.Name == MeatEnm.FiletoKotopoulo.ToString() || this.Name == MeatEnm.Mpifteki.ToString() || this.Name == MeatEnm.Kotompoukies.ToString())
                return this.Price = 7.6m;
            else
                return this.Price = 7.5m;
        }
    }
}

