﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasAresei.OrderFoodForms;

namespace MasAresei
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void saladBtn_Click(object sender, EventArgs e)
        {
            SaladForm saladForm = new SaladForm();
            saladForm.ShowDialog();
        }
    }
}