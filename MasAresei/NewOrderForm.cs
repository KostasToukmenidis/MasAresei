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
            CreateFoodCategoryButtons();
        }

        private void CreateFoodCategoryButtons()
        {
            int x = 36; //x axis
            int y = 36; //y axis
            int index = 1;

            foreach (var item in _context.FoodCategories.ToList())
            {
                if (index > _context.FoodCategories.ToList().Count / 2)
                {
                    y = 36;
                    Button newButton = new Button();
                    this.Controls.Add(newButton);
                    newButton.BackColor = Color.RoyalBlue;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.ForeColor = SystemColors.ButtonFace;
                    newButton.Location = new Point(260, x);
                    newButton.Name = item.Name + "Btn";
                    newButton.Size = new Size(234, 78);
                    newButton.TabIndex = 0;
                    newButton.Text = item.Name;
                    newButton.UseVisualStyleBackColor = false;
                    newButton.Click += new EventHandler(this.button_Click);
                    x += 100;
                }
                else
                {
                    Button newButton = new Button();
                    this.Controls.Add(newButton);
                    newButton.BackColor = Color.RoyalBlue;
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.ForeColor = SystemColors.ButtonFace;
                    newButton.Location = new Point(12, y);
                    newButton.Name = item.Name + "Btn";
                    newButton.Size = new Size(234, 78);
                    newButton.TabIndex = 0;
                    newButton.Text = item.Name;
                    newButton.UseVisualStyleBackColor = false;
                    newButton.Click += new EventHandler(this.button_Click);
                    y += 100;
                }
                index++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
            OpeningOrderFoodForms(btn.Name);
        }

        private void OpeningOrderFoodForms(string str)
        {
            foreach (var item in _context.FoodCategories.ToList())
            {
                if (item.Name + "Btn" == str)
                {
                    Form newForm = new Form();
                    newForm.CreatingOrderFoodForms(item.Name);
                    //newForm.StartPosition = FormStartPosition.CenterScreen;
                    //newForm.Size = new Size(900, 600);
                    //newForm.Text = item.Name;
                    //newForm.Name = item.Name + "Form";
                    newForm.ShowDialog();
                }   
            }
        }
    }
}
