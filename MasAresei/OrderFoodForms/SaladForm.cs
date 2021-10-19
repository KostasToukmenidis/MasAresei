using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.Models.Food_Models;

namespace MasAresei.OrderFoodForms
{
    public partial class SaladForm : Form
    {
        public SaladForm()
        {
            InitializeComponent();
        }

        public Salad salad = new Salad();

        private void SaladForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 51; i++)
            { 
                quantityCmbBox.Items.Add(i);
            }
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            GetSalad();
            GetSaladQuantity();
            salad.GetPrice();
            CustomersForm.newOrderList.Add(salad);
            MessageBox.Show(salad.Price.ToString()); //TEST
            this.Hide();
        }

        private string GetSalad()
        {
            if (agkourontomataRdBtn.Checked)
            {
                salad.Name = agkourontomataRdBtn.Text;
                return salad.Name;
            }
            else if (xoriatikiRdBtn.Checked)
            {
                salad.Name = xoriatikiRdBtn.Text;
                return salad.Name;
            }       
            else if (cesarsRdBtn.Checked)
            {
                salad.Name = cesarsRdBtn.Text;
                return salad.Name;
            }
            else if (maroulosalataRdBtn.Checked)
            {
                salad.Name = maroulosalataRdBtn.Text;
                return salad.Name;
            }
            else
            {
                salad.Name = cefsRdBtn.Text;
                return salad.Name;
            }
        }

        private void GetSaladQuantity()
        {
            if (quantityCmbBox.Text == String.Empty)
                salad.Quantity = 1;
            else
                salad.Quantity = Convert.ToInt32(quantityCmbBox.Text);
        }
    }
}
