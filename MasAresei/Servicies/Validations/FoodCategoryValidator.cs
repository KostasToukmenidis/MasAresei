using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasAresei.Servicies.Validations
{
    public static class FoodCategoryValidator
    {
        public static bool ValidateFoodCategoryName(string fCategoryName)
        {
            if (string.IsNullOrEmpty(fCategoryName))
            {
                MessageBox.Show("Food category is required.");
                return false;
            }
            else if (fCategoryName.Length > 50)
            {
                MessageBox.Show("Food Category can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        }
    }
}
