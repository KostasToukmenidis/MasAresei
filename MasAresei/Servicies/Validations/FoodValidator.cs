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

        public static bool ValidateFoodPrice(this decimal foodPrice)
        {
            string[] fPChars = { "0","1","2","3","4","5","6","7","8","9",",","." };
            decimal d;
            if (string.IsNullOrEmpty(foodPrice.ToString()))
            {
                MessageBox.Show("Food price is required.");
                return false;
            }
            else if (!Decimal.TryParse(foodPrice.ToString(), out d) || d < 0)
            {
                MessageBox.Show("Price is a positive number.");
                return false;
            }
            else
                return true;
        }
    }
}
