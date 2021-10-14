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
        private Customer customer = new Customer();
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

        private void lastNameTbox_Validating(object sender, CancelEventArgs e)
        {
            ValidateLastName();
        }

        private void phoneNumberTbox_TextChanged(object sender, EventArgs e)
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

        public void ValidateFirstName()
        {
            if (firstNameTbox.Text == "")
                error.SetError(firstNameTbox, "First Name is necessary to procced.");
            else if (firstNameTbox.Text.Length > 50)
                error.SetError(firstNameTbox, "First Name too big, try something shorter.");
            else if (!firstNameTbox.Text.All(c => Char.IsLetter(c))) 
                error.SetError(firstNameTbox, "This field must only contain A-z letters.");
            else
                error.SetError(firstNameTbox, "");
        }

        public void ValidateLastName()
        {
            if (lastNameTbox.Text == "")
                error.SetError(lastNameTbox, "Last Name is necessary to procced.");
            else if (lastNameTbox.Text.Length > 50)
                error.SetError(lastNameTbox, "Last Name too big, try something shorter.");
            else if (!lastNameTbox.Text.All(c => Char.IsLetter(c)))
                error.SetError(lastNameTbox, "This field must only contain A-z letters.");
            else
                error.SetError(firstNameTbox, "");
        }

        public void ValidatePhoneNumber()
        {
            if (phoneNumberTbox.Text == "")
                error.SetError(phoneNumberTbox, "Phone number is necessary to procced.");
            else if (phoneNumberTbox.Text.Length != 10)
                error.SetError(phoneNumberTbox, "Not a valid phone nubmer.");
            else if (!phoneNumberTbox.Text.All(c => Char.IsDigit(c)))
                error.SetError(phoneNumberTbox, "This field must only contain numbers.");
            else
                error.SetError(phoneNumberTbox, "");
        }

        public void ValidateAddress()
        {
            if (addressTbox.Text == "")
                error.SetError(addressTbox, "Address is necessary to procced.");
            else if (addressTbox.Text.Length > 50)
                error.SetError(addressTbox, "Address too big, try something shorter.");
            else if (!addressTbox.Text.All(c => Char.IsLetter(c)))
                error.SetError(addressTbox, "This field must only contain A-z letters.");
            else
                error.SetError(addressTbox, "");
        }

        public void ValidateAddressNumber()
        {
            if (addressNumberTbox.Text == "")
                error.SetError(addressNumberTbox, "Address Number is necessary to procced.");
            else if (addressNumberTbox.Text.Length > 3)
                error.SetError(addressNumberTbox, "Address too big, try something shorter.");
            else if (!addressNumberTbox.Text.All(c => Char.IsDigit(c)))
                error.SetError(addressNumberTbox, "This field must only contain numbers.");
            else
                error.SetError(addressNumberTbox, "");
        }

        public void ValidateAddressArea()
        {
            if (addressAreaTbox.Text == "")
                error.SetError(addressAreaTbox, "Area is necessary to procced.");
            else if (addressAreaTbox.Text.Length > 50)
                error.SetError(addressAreaTbox, "Area too big, try something shorter.");
            else if (!addressAreaTbox.Text.All(c => Char.IsLetter(c)))
                error.SetError(addressAreaTbox, "This field must only contain A-z letters.");
            else
                error.SetError(addressAreaTbox, "");
        }

        #endregion
    }
}
