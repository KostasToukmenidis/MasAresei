using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.Models;

namespace MasAresei
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private int customerId = 0;
        public Customer customer = new Customer();
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        //private readonly InitialForm initialForm = new InitialForm(); //Initiallizing Form1 here causes stack overflow exception

        //Clearing Form every time it loads and setting the data in the grid
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }

        private void saveOrEditBtn_Click(object sender, EventArgs e)
        {
            customer.FirstName = firstNameTbox.Text.Trim();
            customer.LastName = lastNameTbox.Text.Trim();
            customer.PhoneNumber = phoneNumberTbox.Text.Trim();
            customer.Address = addressTbox.Text.Trim();
            customer.AddressNumber = Convert.ToInt32(addressNumberTbox.Text.Trim());
            customer.AddressArea = addressAreaTbox.Text.Trim();

            if (customerId > 0)
                _context.Entry(customer).State = EntityState.Modified;
            else
            {
                _context.Customers.Add(customer);
            }
            _context.SaveChanges();
            ClearData();
            SetDataInGridView();
            MessageBox.Show("Record Save Successfully");
        }

        private void customersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Making sure that the user hasnt clicked on the grid header
            if (customersGrid.CurrentCell.RowIndex != -1)
            {
                if (customersGrid.CurrentRow != null)
                {
                    customerId = Convert.ToInt32(customersGrid.CurrentRow.Cells["Id"].Value);
                    customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
                    firstNameTbox.Text = customer.FirstName;
                    lastNameTbox.Text = customer.LastName;
                    phoneNumberTbox.Text = customer.PhoneNumber;
                    addressTbox.Text = customer.Address;
                    addressNumberTbox.Text = customer.AddressNumber.ToString();
                    addressAreaTbox.Text = customer.AddressArea;
                }

                saveOrEditBtn.Text = "Edit";
                deleteBtn.Enabled = true;
                deleteBtn.BackColor = Color.Firebrick;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                ClearData();
                SetDataInGridView();
                MessageBox.Show("Record Deleted Successfully");
            }
        }

        //// Using this method to show InitialForm if I decide to hide it when CustomersForm2 Pops
        //private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    InitialForm initialForm = new InitialForm();
        //    initialForm.Show();
        //}

        //Reseting CustomersForm
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        //--------CUSTOM METHODS--------------

        //Reseting my customers form
        public void ClearData()
        {
            firstNameTbox.Text = lastNameTbox.Text = phoneNumberTbox.Text = addressTbox.Text = addressNumberTbox.Text =
                addressAreaTbox.Text = string.Empty;
            deleteBtn.Enabled = false;
            deleteBtn.BackColor = Color.IndianRed;
            saveOrEditBtn.Text = "Save";
            customerId = 0;
        }

        //Setting the data in the customers grid
        public void SetDataInGridView()
        {
            //customersGrid.AutoGenerateColumns = false;
            customersGrid.DataSource = _context.Customers.ToList<Customer>();
        }

        
    }
}
