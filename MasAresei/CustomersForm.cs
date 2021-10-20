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
using MasAresei.Interfaces;
using MasAresei.Models;
using MasAresei.Servicies.Validations;
using Color = System.Drawing.Color;

namespace MasAresei
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        public static int customerId = 0;
        public Customer customer = new Customer();
        public Order order;
        public static List<IFoodPricing> newOrderList = new List<IFoodPricing>();
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider error = new ErrorProvider();

        #region Communication with database and events

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

                ValidateAll();

                if (ValidateCustomer() == true)
                {
                    saveOrEditBtn.Enabled = true;
                    if (customerId > 0)
                    {
                        _context.Entry(customer).State = EntityState.Modified;
                    }
                    else
                    {
                        _context.Customers.Add(customer);
                    }
                    _context.SaveChanges();
                    ClearData();
                    SetDataInGridView();
                    MessageBox.Show("Record Save Successfully");
                }
                else
                {
                    this.Focus();
                    //MessageBox.Show("Fill with correct info.");
                }
                //if (customerId > 0)
                //{
                //    _context.Entry(customer).State = EntityState.Modified;
                //}
                //else
                //{
                //    _context.Customers.Add(customer);
                //}
                //_context.SaveChanges();
                //ClearData();
                //SetDataInGridView();
                //MessageBox.Show("Record Save Successfully");

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

        private void lastNameTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateLastName();
        }

        private void phoneNumberTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidatePhoneNumber();
        }

        private void addressTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateAddress();
        }

        private void addressNumberTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateAddressNumber();
        }

        private void addressAreaTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateAddressArea();
        }

        #endregion

        #region Custom Methods for validation

        public bool ValidateCustomer()
        {
            if (CustomerValidator.ValidateFirstName(customer.FirstName) &&
                CustomerValidator.ValidateLastName(customer.LastName) &&
                CustomerValidator.ValidatePhoneNumber(customer.PhoneNumber) &&
                CustomerValidator.ValidateAddress(customer.Address) &&
                CustomerValidator.ValidateAddressNumber(customer.AddressNumber) &&
                CustomerValidator.ValidateAddressArea(customer.AddressArea))
                return true;  //MessageBox.Show("All fields are valid.");
            else
                return false; //MessageBox.Show("Some fields are not valid.");
        }

        public void ValidateAll()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidatePhoneNumber();
            ValidateAddress();
            ValidateAddressNumber();
            ValidateAddressArea();
        }

        public void ValidateFirstName()
        {
            if (string.IsNullOrEmpty(firstNameTbox.Text))
            {
                error.SetError(firstNameTbox, "First Name is necessary to procced.");
                //saveOrEditBtn.Enabled = false;
                firstNameTbox.Focus();
            }
            else if (firstNameTbox.Text.Length > 50)
            {
                error.SetError(firstNameTbox, "First Name too big, try something shorter.");
                firstNameTbox.Focus();
            }
            //else if (!firstNameTbox.Text.All(c => Char.IsLetter(c)))
            //{
            //    error.SetError(firstNameTbox, "First Name too big, try something shorter.");
            //    firstNameTbox.Focus();
            //}
            else
            {
                //saveOrEditBtn.Enabled = true;
                error.SetError(firstNameTbox, "");
            }
        }

        public void ValidateLastName()
        {
            if (string.IsNullOrEmpty(lastNameTbox.Text))
            {
                error.SetError(lastNameTbox, "Last Name is necessary to procced.");
                lastNameTbox.Focus();
            }
            else if (lastNameTbox.Text.Length > 50)
            {
                error.SetError(lastNameTbox, "Last Name too big, try something shorter.");
                lastNameTbox.Focus();
            }
            //else if (!lastNameTbox.Text.All(c => Char.IsLetter(c)))
            //{
            //    error.SetError(lastNameTbox, "This field must only contain A-z letters.");
            //    lastNameTbox.Focus();
            //}
            else
            {
                error.SetError(firstNameTbox, "");
            }
        }

        public void ValidatePhoneNumber()
        {
            if (string.IsNullOrEmpty(phoneNumberTbox.Text))
            {
                error.SetError(phoneNumberTbox, "Phone number is necessary to procced.");
                //saveOrEditBtn.Enabled = false;
                phoneNumberTbox.Focus();
            }
            else if (phoneNumberTbox.Text.Length != 3)
            {
                error.SetError(phoneNumberTbox, "Not a valid phone nubmer.");
                phoneNumberTbox.Focus();
            }
            else if (!phoneNumberTbox.Text.All(c => Char.IsDigit(c)))
            {
                error.SetError(phoneNumberTbox, "This field must only contain numbers.");
                phoneNumberTbox.Focus();
            }
            else
            {
                error.SetError(phoneNumberTbox, "");
            }
        }

        public void ValidateAddress()
        {
            if (string.IsNullOrEmpty(addressTbox.Text))
            {
                error.SetError(addressTbox, "Address is necessary to procced.");
                addressTbox.Focus();
            }
            else if (addressTbox.Text.Length > 50)
            {
                error.SetError(addressTbox, "Address too big, try something shorter.");
                addressTbox.Focus();
            }
            //else if (!addressTbox.Text.All(c => Char.IsLetter(c)))
            //{
            //    error.SetError(addressTbox, "This field must only contain A-z letters.");
            //    addressTbox.Focus();
            //}
            else
            {
                error.SetError(addressTbox, "");
            }
        }

        public void ValidateAddressNumber()
        {
            if (string.IsNullOrEmpty(addressNumberTbox.Text))
            {
                error.SetError(addressNumberTbox, "Address Number is necessary to procced.");
                addressNumberTbox.Focus();
            }
            else if (addressNumberTbox.Text.Length > 3)
            {
                error.SetError(addressNumberTbox, "Address too big, try something shorter.");
                addressNumberTbox.Focus();
            }
            else if (!addressNumberTbox.Text.All(c => Char.IsDigit(c)))
            {
                error.SetError(addressNumberTbox, "This field must only contain numbers.");
                addressNumberTbox.Focus();
            }
            else
            {
                error.SetError(addressNumberTbox, "");
            }
        }

        public void ValidateAddressArea()
        {
            if (string.IsNullOrEmpty(addressAreaTbox.Text))
            {
                error.SetError(addressAreaTbox, "Area is necessary to procced.");
                addressAreaTbox.Focus();
            }
            else if (addressAreaTbox.Text.Length > 50)
            {
                error.SetError(addressAreaTbox, "Area too big, try something shorter.");
                addressAreaTbox.Focus();
            }
            //else if (!addressAreaTbox.Text.All(c => Char.IsLetter(c)))
            //{
            //    error.SetError(addressAreaTbox, "This field must only contain A-z letters.");
            //    addressAreaTbox.Focus();
            //}
            else
            {
                error.SetError(addressAreaTbox, "");
            }
        }

        #endregion

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            newOrderList.RemoveAll(x => x.GetPrice() != 0);
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
