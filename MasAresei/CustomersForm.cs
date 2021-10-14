﻿using System;
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
using Color = System.Drawing.Color;

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
        private readonly ErrorProvider error = new ErrorProvider();

        #region Communication with database and button events

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }

        private void saveOrEditBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Try fill all the boxes wtith the correct information.");
            }
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

        //Clearing my form
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        #endregion


        #region InitialForm show if hidden when CustomersForm pops

        ////Using this method if I want to hide InitialForm when user uses the CustomersForm---uncoment from Designer.cs
        //private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    InitialForm initialForm = new InitialForm();
        //    initialForm.Show();
        //}

        #endregion
        

        #region Custom Methods for database communication

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


        #endregion

        #region Validation Events

        private void firstNameTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateFirstName();
        }

        #endregion

        #region Custom Methods for validation

        public void ValidateFirstName()
        {
            if (firstNameTbox.Text == "")
                error.SetError(firstNameTbox, "First name is necessary to procced.");
            else if (firstNameTbox.Text.Length > 50)
                error.SetError(firstNameTbox, "First name too big, try something shorter.");
            else if (!firstNameTbox.Text.All(c => Char.IsLetter(c))) 
                error.SetError(firstNameTbox, "Name must only contain A-z letters.");
            else
                error.SetError(firstNameTbox, "");
        }

        #endregion


    }
}
