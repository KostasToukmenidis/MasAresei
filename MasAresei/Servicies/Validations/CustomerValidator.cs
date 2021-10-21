using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.Models;

namespace MasAresei.Servicies.Validations
{
    public static class CustomerValidator
    {
        public static bool ValidateFirstName(string fName)
        {
            if (string.IsNullOrEmpty(fName))
            {
                MessageBox.Show("First name is required.");
                return false;
            }
            else if (fName.Length > 50)
            {
                MessageBox.Show("First name can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateLastName(string lName)
        {
            if (string.IsNullOrEmpty(lName))
            {
                MessageBox.Show("Last name is required.");
                return false;
            }
            else if (lName.Length > 50)
            {
                MessageBox.Show("Last name can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidatePhoneNumber(string pNumber)
        {
            if (string.IsNullOrEmpty(pNumber))
            {
                MessageBox.Show("Phone number is required.");
                return false;
            }
            else if (pNumber.Length != 3)
            {
                MessageBox.Show("Phone number must be 3 chars long.");
                return false;
            }
            else if (!pNumber.All(c => Char.IsDigit(c)))
            {
                MessageBox.Show("Phone number should only contain digits.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.");
                return false;
            }
            else if (address.Length > 50)
            {
                MessageBox.Show("Address can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateAddressNumber(int? adNumber)
        {
            if (adNumber == null || adNumber == 0)
            {
                MessageBox.Show("Address is required.");
                return false;
            }
            else if (!adNumber.ToString().All(c => Char.IsDigit(c)))
            {
                MessageBox.Show("Address number should only contain digits.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateAddressArea(string adArea)
        {
            if (string.IsNullOrEmpty(adArea))
            {
                MessageBox.Show("Address area is required.");
                return false;
            }
            else if (adArea.Length > 50)
            {
                MessageBox.Show("Address area can be 50 characters long at most.");
                return false;
            }
            else
                return true;
        }
    }
}
