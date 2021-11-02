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

        public int customerId = 0;
        public Customer customer = new Customer();
        public Order order;
        private readonly MasAreseiDbContext _context = new MasAreseiDbContext();
        private readonly ErrorProvider _error = new ErrorProvider();

        #region Communication with database and Click Events

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGrid();
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

                if (ValidateCustomer())
                {
                    //saveOrEditBtn.Enabled = true;
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
                    SetDataInGrid();
                    MessageBox.Show("Record Save Successfully");
                }
                else
                {
                    this.Focus();
                }
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
                SetDataInGrid();
                MessageBox.Show("Record Deleted Successfully");
            }
        }

        //Clearing my form
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Custom methods to reset Form and set the data in the Grid

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
        public void SetDataInGrid()
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
                return true; 
            else
                return false;
        }

        public void ValidateFirstName()
        {
            if (string.IsNullOrEmpty(firstNameTbox.Text))
            {
                _error.SetError(firstNameTbox, "First name is necessary to procced.");
                firstNameTbox.Focus();
            }
            else if (firstNameTbox.Text.Length > 50)
            {
                _error.SetError(firstNameTbox, "First name can't be that long, try something shorter.");
                firstNameTbox.Focus();
            }
            else
            {
                _error.SetError(firstNameTbox, "");
            }
        }

        public void ValidateLastName()
        {
            if (string.IsNullOrEmpty(lastNameTbox.Text))
            {
                _error.SetError(lastNameTbox, "Last name is necessary to procced.");
                lastNameTbox.Focus();
            }
            else if (lastNameTbox.Text.Length > 50)
            {
                _error.SetError(lastNameTbox, "Last name can't be that long, try something shorter.");
                lastNameTbox.Focus();
            }
            else
            {
                _error.SetError(firstNameTbox, "");
            }
        }

        public void ValidatePhoneNumber()
        {
            if (string.IsNullOrEmpty(phoneNumberTbox.Text))
            {
                _error.SetError(phoneNumberTbox, "Phone number is necessary to procced.");
                phoneNumberTbox.Focus();
            }
            else if (phoneNumberTbox.Text.Length != 3)
            {
                _error.SetError(phoneNumberTbox, "All phone numbers should have 3 digits.");
                phoneNumberTbox.Focus();
            }
            else if (!phoneNumberTbox.Text.All(c => Char.IsDigit(c)))
            {
                _error.SetError(phoneNumberTbox, "Phone number must only contain numbers.");
                phoneNumberTbox.Focus();
            }
            else
            {
                _error.SetError(phoneNumberTbox, "");
            }
        }

        public void ValidateAddress()
        {
            if (string.IsNullOrEmpty(addressTbox.Text))
            {
                _error.SetError(addressTbox, "Address is necessary to procced.");
                addressTbox.Focus();
            }
            else if (addressTbox.Text.Length > 50)
            {
                _error.SetError(addressTbox, "Address can't be that long, try something shorter.");
                addressTbox.Focus();
            }
            else
            {
                _error.SetError(addressTbox, "");
            }
        }

        public void ValidateAddressNumber()
        {
            if (string.IsNullOrEmpty(addressNumberTbox.Text))
            {
                _error.SetError(addressNumberTbox, "Address number is necessary to procced.");
                addressNumberTbox.Focus();
            }
            else if (!addressNumberTbox.Text.All(c => Char.IsDigit(c)))
            {
                _error.SetError(addressNumberTbox, "Address number should only contain nubmers.");
                addressNumberTbox.Focus();
            }
            else
            {
                _error.SetError(addressNumberTbox, "");
            }
        }

        public void ValidateAddressArea()
        {
            if (string.IsNullOrEmpty(addressAreaTbox.Text))
            {
                _error.SetError(addressAreaTbox, "Area is necessary to procced.");
                addressAreaTbox.Focus();
            }
            else if (addressAreaTbox.Text.Length > 50)
            {
                _error.SetError(addressAreaTbox, "Area can't be that long, try something shorter.");
                addressAreaTbox.Focus();
            }
            else
            {
                _error.SetError(addressAreaTbox, "");
            }
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
    }
}
