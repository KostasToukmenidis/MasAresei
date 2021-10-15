﻿
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.customersLbl = new System.Windows.Forms.Label();
            this.ordersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saveOrEditBtn
            // 
            this.saveOrEditBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveOrEditBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveOrEditBtn.Location = new System.Drawing.Point(15, 329);
            this.saveOrEditBtn.Name = "saveOrEditBtn";
            this.saveOrEditBtn.Size = new System.Drawing.Size(87, 42);
            this.saveOrEditBtn.TabIndex = 0;
            this.saveOrEditBtn.Text = "Save";
            this.saveOrEditBtn.UseVisualStyleBackColor = false;
            this.saveOrEditBtn.Click += new System.EventHandler(this.saveOrEditBtn_Click);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameLbl.Location = new System.Drawing.Point(9, 106);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(76, 17);
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
            this.firstNameTbox.Size = new System.Drawing.Size(128, 20);
            this.firstNameTbox.TabIndex = 3;
            this.firstNameTbox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTbox_Validating);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameLbl.Location = new System.Drawing.Point(175, 106);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.lastNameLbl.TabIndex = 4;
            this.lastNameLbl.Text = "Last Name";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumberLbl.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumberLbl.Location = new System.Drawing.Point(9, 179);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(49, 17);
            this.phoneNumberLbl.TabIndex = 5;
            this.phoneNumberLbl.Text = "Phone";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLbl.ForeColor = System.Drawing.Color.DimGray;
            this.addressLbl.Location = new System.Drawing.Point(175, 179);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(60, 17);
            this.addressLbl.TabIndex = 6;
            this.addressLbl.Text = "Address";
            // 
            // addressNumberLbl
            // 
            this.addressNumberLbl.AutoSize = true;
            this.addressNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressNumberLbl.ForeColor = System.Drawing.Color.DimGray;
            this.addressNumberLbl.Location = new System.Drawing.Point(9, 251);
            this.addressNumberLbl.Name = "addressNumberLbl";
            this.addressNumberLbl.Size = new System.Drawing.Size(72, 17);
            this.addressNumberLbl.TabIndex = 7;
            this.addressNumberLbl.Text = "Address #";
            // 
            // addressAreaLbl
            // 
            this.addressAreaLbl.AutoSize = true;
            this.addressAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressAreaLbl.ForeColor = System.Drawing.Color.DimGray;
            this.addressAreaLbl.Location = new System.Drawing.Point(175, 251);
            this.addressAreaLbl.Name = "addressAreaLbl";
            this.addressAreaLbl.Size = new System.Drawing.Size(38, 17);
            this.addressAreaLbl.TabIndex = 8;
            this.addressAreaLbl.Text = "Area";
            // 
            // lastNameTbox
            // 
            this.lastNameTbox.Location = new System.Drawing.Point(178, 126);
            this.lastNameTbox.Name = "lastNameTbox";
            this.lastNameTbox.Size = new System.Drawing.Size(128, 20);
            this.lastNameTbox.TabIndex = 9;
            this.lastNameTbox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberTbox_TextChanged);
            // 
            // phoneNumberTbox
            // 
            this.phoneNumberTbox.Location = new System.Drawing.Point(12, 195);
            this.phoneNumberTbox.Name = "phoneNumberTbox";
            this.phoneNumberTbox.Size = new System.Drawing.Size(128, 20);
            this.phoneNumberTbox.TabIndex = 10;
            // 
            // addressTbox
            // 
            this.addressTbox.Location = new System.Drawing.Point(178, 195);
            this.addressTbox.Name = "addressTbox";
            this.addressTbox.Size = new System.Drawing.Size(128, 20);
            this.addressTbox.TabIndex = 11;
            this.addressTbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTbox_Validating);
            // 
            // addressNumberTbox
            // 
            this.addressNumberTbox.Location = new System.Drawing.Point(12, 267);
            this.addressNumberTbox.Name = "addressNumberTbox";
            this.addressNumberTbox.Size = new System.Drawing.Size(128, 20);
            this.addressNumberTbox.TabIndex = 12;
            this.addressNumberTbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressNumberTbox_Validating);
            // 
            // addressAreaTbox
            // 
            this.addressAreaTbox.Location = new System.Drawing.Point(178, 267);
            this.addressAreaTbox.Name = "addressAreaTbox";
            this.addressAreaTbox.Size = new System.Drawing.Size(128, 20);
            this.addressAreaTbox.TabIndex = 13;
            this.addressAreaTbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressAreaTbox_Validating);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(108, 329);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(87, 42);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Coral;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Location = new System.Drawing.Point(201, 329);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(87, 42);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // customersLbl
            // 
            this.customersLbl.AutoSize = true;
            this.customersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customersLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.customersLbl.Location = new System.Drawing.Point(456, 20);
            this.customersLbl.Name = "customersLbl";
            this.customersLbl.Size = new System.Drawing.Size(109, 24);
            this.customersLbl.TabIndex = 16;
            this.customersLbl.Text = "Customers";
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ordersBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersBtn.Location = new System.Drawing.Point(108, 394);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(87, 42);
            this.ordersBtn.TabIndex = 17;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = false;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1116, 503);
            this.Controls.Add(this.ordersBtn);
            this.Controls.Add(this.customersLbl);
            this.Controls.Add(this.clearBtn);
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
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label customersLbl;
        private System.Windows.Forms.Button ordersBtn;
    }
}