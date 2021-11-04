using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.Models;
using MasAresei.OrderFoodFormsCreationCode;

namespace MasAresei
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
        }

        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            AdjustingFoodCategoryButtons();//Populating the form with buttons
        }

        #region Creating and naming the buttons that open the forms

        //Naming and setting the location of the buttons that open to food category forms
        private void AdjustingFoodCategoryButtons()
        {
            int x = 36; //x axis
            int y = 36; //y axis
            int index = 0;

            foreach (var item in _context.FoodCategories.ToList())
            {
                if (index > _context.FoodCategories.ToList().Count / 2)
                {
                    y = 36;
                    CateogiresButtonCreation(item.Name, 260, x);
                    x += 100;
                }
                else
                {
                    CateogiresButtonCreation(item.Name, 12, y);
                    y += 100;
                }
                index++;
            }
        }

        //Creating the buttons that open the food categories forms
        private void CateogiresButtonCreation(string btnName, int xAxis, int yAxis)
        {
            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.BackColor = Color.RoyalBlue;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.ForeColor = SystemColors.ButtonFace;
            newButton.Location = new Point(xAxis, yAxis);
            newButton.Name = btnName + "Btn";
            newButton.Size = new Size(234, 78);
            newButton.TabIndex = 0;
            newButton.Text = btnName;
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += new EventHandler(this.button_Click);
            yAxis += 100;
        }

        #endregion


        //Custom Click Event that opens the selected food category form, called in my CateogiresButtonCreation method
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            OpeningOrderFoodForms(btn.Name); //Opening one of the Order Food Forms
        }

        private void OpeningOrderFoodForms(string str)
        {
            foreach (var item in _context.FoodCategories.ToList())
            {
                if (item.Name + "Btn" == str)
                {
                    Form newForm = new Form();
                    OrderFoodFormCreating.CreatingOrderFoodForms(newForm, item.Name); //Creating the Forms
                    
                    newForm.ShowDialog();
                }   
            }
        }
    }
}
