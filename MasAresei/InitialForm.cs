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

        private Form activeForm = null;

        private void InitialForm_Load(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
        }

        private void customersWnd_Click(object sender, EventArgs e)
        {
            //this.Hide();//using this line if I want to hide InitialForm when user uses the CustomersForm
            //customersForm.ShowDialog();
            openChildForm(new CustomersForm());
        }

        private void foodCategoryWindowBtn_Click(object sender, EventArgs e)
        {
            //foodCategoryForm.ShowDialog();
            openChildForm(new FoodCategoryForm());
        }

        private void foodWindowBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FoodForm());
        }

        //Custom Method to open child Forms in mainFormsPanel

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)  //Checking if there's an active form
                activeForm.Close(); //If there is one i close it
            
            activeForm = childForm; //Storing the form that opens
            childForm.TopLevel = false; //Child form behaves like a controll, doesnt pop like a form
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainFormsPanel.Controls.Add(childForm); // Adding form to the mainFormsPanel
            mainFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
