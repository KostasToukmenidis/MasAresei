using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;
using MasAresei.Models.Food_Enums;

namespace MasAresei.Models.Food_Models
{
    public class Sandwich : FoodParent, IFoodPricing
    {
        public string MeatName { get; set; }
        public string BreadName { get; set; }
        public string SauceName { get; set; } = String.Empty;

        public decimal GetPrice()
        {
            if (this.BreadName == BreadEnm.Araviki.ToString() || this.BreadName == BreadEnm.Tortilla.ToString())
            {
                if (this.MeatName == MeatEnm.GyrosXoirinos.ToString() ||
                    this.MeatName == MeatEnm.GyrosKotopoulo.ToString() ||
                    this.MeatName == MeatEnm.KontosouvliXoirino.ToString() ||
                    this.MeatName == MeatEnm.KontosouvliKotopoulo.ToString() ||
                    this.MeatName == MeatEnm.MpiftekiGemisto.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.9m;
                    else
                        return this.Price = 4.2m;
                }
                else if (this.MeatName == MeatEnm.SouvlakiKotopoulo.ToString()
                         || this.MeatName == MeatEnm.MprizolakiXoirino.ToString()
                         || this.MeatName == MeatEnm.FiletoKotopoulo.ToString()
                         || this.MeatName == MeatEnm.Mpifteki.ToString()
                         || this.MeatName == MeatEnm.Kotompoukies.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.8m;
                    else
                        return this.Price = 4.1m;
                }
                else if (this.MeatName == MeatEnm.SouvlakiXoirino.ToString() ||
                         this.MeatName == MeatEnm.Pantseta.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.6m;
                    else
                        return this.Price = 3.9m;
                }
                else
                    return Price = 0m;
            }
            else if (this.BreadName == BreadEnm.Kypriaki.ToString())
            {
                if (this.MeatName == MeatEnm.GyrosXoirinos.ToString()
                    || this.MeatName == MeatEnm.GyrosKotopoulo.ToString()
                    || this.MeatName == MeatEnm.KontosouvliXoirino.ToString()
                    || this.MeatName == MeatEnm.KontosouvliKotopoulo.ToString()
                    || this.MeatName == MeatEnm.MpiftekiGemisto.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.7m;
                    else
                        return this.Price = 4m;
                }
                else if (this.MeatName == MeatEnm.SouvlakiKotopoulo.ToString()
                         || this.MeatName == MeatEnm.MprizolakiXoirino.ToString()
                         || this.MeatName == MeatEnm.FiletoKotopoulo.ToString()
                         || this.MeatName == MeatEnm.Mpifteki.ToString()
                         || this.MeatName == MeatEnm.Kotompoukies.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.6m;
                    else
                        return this.Price = 3.9m;
                }
                else if (this.MeatName == MeatEnm.SouvlakiXoirino.ToString() ||
                         this.MeatName == MeatEnm.Pantseta.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.4m;
                    else
                        return this.Price = 3.7m;
                }
                else
                    return Price = 0m;
            }
            else
            {
                if (this.MeatName == MeatEnm.GyrosXoirinos.ToString()
                    || this.MeatName == MeatEnm.GyrosKotopoulo.ToString()
                    || this.MeatName == MeatEnm.KontosouvliXoirino.ToString()
                    || this.MeatName == MeatEnm.KontosouvliKotopoulo.ToString()
                    || this.MeatName == MeatEnm.MpiftekiGemisto.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.3m;
                    else
                        return this.Price = 3.6m;
                }
                else if (this.MeatName == MeatEnm.SouvlakiKotopoulo.ToString()
                         || this.MeatName == MeatEnm.MprizolakiXoirino.ToString()
                         || this.MeatName == MeatEnm.FiletoKotopoulo.ToString()
                         || this.MeatName == MeatEnm.Mpifteki.ToString()
                         || this.MeatName == MeatEnm.Kotompoukies.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.2m;
                    else
                        return this.Price = 3.5m;
                }
                else if (this.MeatName == MeatEnm.SouvlakiXoirino.ToString() ||
                         this.MeatName == MeatEnm.Pantseta.ToString())
                {
                    if (this.SauceName == String.Empty)
                        return this.Price = 3.1m;
                    else
                        return this.Price = 3.4m;
                }
                else
                    return Price = 0m;
            }
        }
    }
}