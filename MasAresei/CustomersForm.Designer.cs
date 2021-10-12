
namespace MasAresei
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveOrEditBtn = new System.Windows.Forms.Button();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.firstNameTbox = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressNumberLbl = new System.Windows.Forms.Label();
            this.addressAreaLbl = new System.Windows.Forms.Label();
            this.lastNameTbox = new System.Windows.Forms.TextBox();
            this.phoneNumberTbox = new System.Windows.Forms.TextBox();
            this.addressTbox = new System.Windows.Forms.TextBox();
            this.addressNumberTbox = new System.Windows.Forms.TextBox();
            this.addressAreaTbox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saveOrEditBtn
            // 
            this.saveOrEditBtn.Location = new System.Drawing.Point(15, 348);
            this.saveOrEditBtn.Name = "saveOrEditBtn";
            this.saveOrEditBtn.Size = new System.Drawing.Size(75, 23);
            this.saveOrEditBtn.TabIndex = 0;
            this.saveOrEditBtn.Text = "Save";
            this.saveOrEditBtn.UseVisualStyleBackColor = true;
            this.saveOrEditBtn.Click += new System.EventHandler(this.saveOrEditBtn_Click);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(34, 91);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name";
            // 
            // customersGrid
            // 
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Location = new System.Drawing.Point(334, 91);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.Size = new System.Drawing.Size(770, 294);
            this.customersGrid.TabIndex = 2;
            this.customersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGrid_CellClick);
            // 
            // firstNameTbox
            // 
            this.firstNameTbox.Location = new System.Drawing.Point(12, 122);
            this.firstNameTbox.Name = "firstNameTbox";
            this.firstNameTbox.Size = new System.Drawing.Size(113, 20);
            this.firstNameTbox.TabIndex = 3;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(184, 91);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 4;
            this.lastNameLbl.Text = "Last Name";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Location = new System.Drawing.Point(34, 165);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(38, 13);
            this.phoneNumberLbl.TabIndex = 5;
            this.phoneNumberLbl.Text = "Phone";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(184, 165);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 13);
            this.addressLbl.TabIndex = 6;
            this.addressLbl.Text = "Address";
            // 
            // addressNumberLbl
            // 
            this.addressNumberLbl.AutoSize = true;
            this.addressNumberLbl.Location = new System.Drawing.Point(34, 250);
            this.addressNumberLbl.Name = "addressNumberLbl";
            this.addressNumberLbl.Size = new System.Drawing.Size(55, 13);
            this.addressNumberLbl.TabIndex = 7;
            this.addressNumberLbl.Text = "Address #";
            // 
            // addressAreaLbl
            // 
            this.addressAreaLbl.AutoSize = true;
            this.addressAreaLbl.Location = new System.Drawing.Point(184, 250);
            this.addressAreaLbl.Name = "addressAreaLbl";
            this.addressAreaLbl.Size = new System.Drawing.Size(29, 13);
            this.addressAreaLbl.TabIndex = 8;
            this.addressAreaLbl.Text = "Area";
            // 
            // lastNameTbox
            // 
            this.lastNameTbox.Location = new System.Drawing.Point(147, 122);
            this.lastNameTbox.Name = "lastNameTbox";
            this.lastNameTbox.Size = new System.Drawing.Size(113, 20);
            this.lastNameTbox.TabIndex = 9;
            // 
            // phoneNumberTbox
            // 
            this.phoneNumberTbox.Location = new System.Drawing.Point(12, 195);
            this.phoneNumberTbox.Name = "phoneNumberTbox";
            this.phoneNumberTbox.Size = new System.Drawing.Size(113, 20);
            this.phoneNumberTbox.TabIndex = 10;
            // 
            // addressTbox
            // 
            this.addressTbox.Location = new System.Drawing.Point(147, 195);
            this.addressTbox.Name = "addressTbox";
            this.addressTbox.Size = new System.Drawing.Size(113, 20);
            this.addressTbox.TabIndex = 11;
            // 
            // addressNumberTbox
            // 
            this.addressNumberTbox.Location = new System.Drawing.Point(12, 281);
            this.addressNumberTbox.Name = "addressNumberTbox";
            this.addressNumberTbox.Size = new System.Drawing.Size(113, 20);
            this.addressNumberTbox.TabIndex = 12;
            // 
            // addressAreaTbox
            // 
            this.addressAreaTbox.Location = new System.Drawing.Point(147, 281);
            this.addressAreaTbox.Name = "addressAreaTbox";
            this.addressAreaTbox.Size = new System.Drawing.Size(113, 20);
            this.addressAreaTbox.TabIndex = 13;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(120, 348);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(224, 348);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1116, 503);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addressAreaTbox);
            this.Controls.Add(this.addressNumberTbox);
            this.Controls.Add(this.addressTbox);
            this.Controls.Add(this.phoneNumberTbox);
            this.Controls.Add(this.lastNameTbox);
            this.Controls.Add(this.addressAreaLbl);
            this.Controls.Add(this.addressNumberLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameTbox);
            this.Controls.Add(this.customersGrid);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.saveOrEditBtn);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveOrEditBtn;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.TextBox firstNameTbox;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label addressNumberLbl;
        private System.Windows.Forms.Label addressAreaLbl;
        private System.Windows.Forms.TextBox lastNameTbox;
        private System.Windows.Forms.TextBox phoneNumberTbox;
        private System.Windows.Forms.TextBox addressTbox;
        private System.Windows.Forms.TextBox addressNumberTbox;
        private System.Windows.Forms.TextBox addressAreaTbox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}