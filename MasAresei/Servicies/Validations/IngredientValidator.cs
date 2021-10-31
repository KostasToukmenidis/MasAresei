using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasAresei.Servicies.Validations
{
    public static class IngredientValidator
    {
        public static bool ValidateIngredientName(this string ingredientName)
        {
            if (string.IsNullOrEmpty(ingredientName))
            {
                MessageBox.Show("Ingredient name is required.");
                return false;
            }
            else if (ingredientName.Length > 50)
            {
                MessageBox.Show("Ingredient name can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        //public class FoodIngredients
        //{
        //    //[Key]
        //    //[Column(Order = 1)]
        //    public int FoodId { get; set; }

        //    //[Key]
        //    //[Column(Order = 2)]
        //    public int IngredientId { get; set; }

        //    public virtual Food Food { get; set; }

        //    public virtual Ingredient Ingredient { get; set; }
        //}
        }
    }
}
