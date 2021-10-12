using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasAresei
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private CustomersForm customersForm = new CustomersForm();

        private void customersWnd_Click(object sender, EventArgs e)
        {
            //this.Hide();//using this line if I want to hide InitialForm when user uses the CustomersForm
            customersForm.ShowDialog();
        }
    }
}
