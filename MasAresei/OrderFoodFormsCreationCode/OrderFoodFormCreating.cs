using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasAresei.OrderFoodFormsCreationCode
{
    public static class OrderFoodFormCreating
    {
        public static void CreatingOrderFoodForms(this Form form, string categoryName)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(900, 600);
            form.Text = categoryName;
            form.Name = categoryName + "Form";
            form.Controls.Add(IngredientCheckBox());
        }

        public static CheckBox IngredientCheckBox(/*MasAreseiDbContext context*/)
        {
            CheckBox checkBox = new CheckBox();
            
            return checkBox;
        }
    }
}
