using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasAresei.Servicies.Validations
{
    public static class FoodValidator
    {
        public static bool ValidateFoodName(this string foodName)
        {
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("Food name is required.");
                return false;
            }
            else if (foodName.Length > 50)
            {
                MessageBox.Show("Food name can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidatePrice(this decimal foodPrice)
        {
            if (string.IsNullOrEmpty(foodPrice.ToString()))
            {
                MessageBox.Show("Food price is required.");
                return false;
            }
            else if (foodPrice < 0)
            {
                MessageBox.Show("Price cannot be negative number.");
                return false;
            }
            else
                return true;
        }
    }
}
