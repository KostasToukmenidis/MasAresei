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
    public partial class BreadForm : Form
    {
        public BreadForm()
        {
            InitializeComponent();
        }

        public Bread bread = new Bread();

        private void BreadForm_Load(object sender, EventArgs e)
        {
            AddItemsToQuantityCmbBox();
            quantityCmbBox.Text = "1";
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            GetBread();
            GetBreadQuantity();
            bread.GetPrice();
            CustomersForm.newOrderList.Add(bread);
            MessageBox.Show(bread.Price.ToString()); //TEST
            quantityCmbBox.Text = 1.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region CustomMethods

        private string GetBread()
        {
            if (pitaRdBtn.Checked)
            {
                bread.Name = pitaRdBtn.Text;
                return bread.Name;
            }
            else if (psomakiRdBtn.Checked)
            {
                bread.Name = psomakiRdBtn.Text;
                return bread.Name;
            }
            else if (kypriakiRdBtn.Checked)
            {
                bread.Name = kypriakiRdBtn.Text;
                return bread.Name;
            }
            else if (aravikiRdBtn.Checked)
            {
                bread.Name = aravikiRdBtn.Text;
                return bread.Name;
            }
            else
            {
                bread.Name = tortillaRdBtn.Text;
                return bread.Name;
            }
        }

        private void GetBreadQuantity()
        {
            if (quantityCmbBox.Text == String.Empty)
                bread.Quantity = 1;
            else
                bread.Quantity = Convert.ToInt32(quantityCmbBox.Text);
        }

        private void AddItemsToQuantityCmbBox()
        {
            for (int i = 1; i < 51; i++)
            {
                quantityCmbBox.Items.Add(i);
            }
        }


        #endregion

    }
}
