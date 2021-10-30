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
        }
    }
}
