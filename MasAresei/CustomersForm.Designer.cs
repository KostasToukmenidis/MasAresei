
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
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sidebarMainPanel = new System.Windows.Forms.Panel();
            this.sidebarBtnPanel = new System.Windows.Forms.Panel();
            this.sidebarHeaderPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.sidebarMainPanel.SuspendLayout();
            this.sidebarBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveOrEditBtn
            // 
            this.saveOrEditBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveOrEditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveOrEditBtn.FlatAppearance.BorderSize = 0;
            this.saveOrEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOrEditBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveOrEditBtn.Location = new System.Drawing.Point(0, 0);
            this.saveOrEditBtn.Name = "saveOrEditBtn";
            this.saveOrEditBtn.Size = new System.Drawing.Size(120, 42);
            this.saveOrEditBtn.TabIndex = 0;
            this.saveOrEditBtn.Text = "Save";
            this.saveOrEditBtn.UseVisualStyleBackColor = false;
            this.saveOrEditBtn.Click += new System.EventHandler(this.saveOrEditBtn_Click);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.firstNameLbl.Location = new System.Drawing.Point(163, 106);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(76, 17);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name";
            // 
            // customersGrid
            // 
            this.customersGrid.AllowUserToDeleteRows = false;
            this.customersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Location = new System.Drawing.Point(334, 91);
            this.customersGrid.MultiSelect = false;
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.ReadOnly = true;
            this.customersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersGrid.Size = new System.Drawing.Size(538, 352);
            this.customersGrid.TabIndex = 2;
            this.customersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGrid_CellClick);
            // 
            // firstNameTbox
            // 
            this.firstNameTbox.Location = new System.Drawing.Point(166, 122);
            this.firstNameTbox.Name = "firstNameTbox";
            this.firstNameTbox.Size = new System.Drawing.Size(128, 20);
            this.firstNameTbox.TabIndex = 3;
            this.firstNameTbox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTbox_Validating);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.lastNameLbl.Location = new System.Drawing.Point(163, 164);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.lastNameLbl.TabIndex = 4;
            this.lastNameLbl.Text = "Last Name";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.phoneNumberLbl.Location = new System.Drawing.Point(163, 222);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(49, 17);
            this.phoneNumberLbl.TabIndex = 5;
            this.phoneNumberLbl.Text = "Phone";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.addressLbl.Location = new System.Drawing.Point(163, 274);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(60, 17);
            this.addressLbl.TabIndex = 6;
            this.addressLbl.Text = "Address";
            // 
            // addressNumberLbl
            // 
            this.addressNumberLbl.AutoSize = true;
            this.addressNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.addressNumberLbl.Location = new System.Drawing.Point(163, 331);
            this.addressNumberLbl.Name = "addressNumberLbl";
            this.addressNumberLbl.Size = new System.Drawing.Size(72, 17);
            this.addressNumberLbl.TabIndex = 7;
            this.addressNumberLbl.Text = "Address #";
            // 
            // addressAreaLbl
            // 
            this.addressAreaLbl.AutoSize = true;
            this.addressAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressAreaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.addressAreaLbl.Location = new System.Drawing.Point(163, 381);
            this.addressAreaLbl.Name = "addressAreaLbl";
            this.addressAreaLbl.Size = new System.Drawing.Size(38, 17);
            this.addressAreaLbl.TabIndex = 8;
            this.addressAreaLbl.Text = "Area";
            // 
            // lastNameTbox
            // 
            this.lastNameTbox.Location = new System.Drawing.Point(166, 184);
            this.lastNameTbox.Name = "lastNameTbox";
            this.lastNameTbox.Size = new System.Drawing.Size(128, 20);
            this.lastNameTbox.TabIndex = 9;
            // 
            // phoneNumberTbox
            // 
            this.phoneNumberTbox.Location = new System.Drawing.Point(166, 238);
            this.phoneNumberTbox.Name = "phoneNumberTbox";
            this.phoneNumberTbox.Size = new System.Drawing.Size(128, 20);
            this.phoneNumberTbox.TabIndex = 10;
            this.phoneNumberTbox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberTbox_Validating);
            // 
            // addressTbox
            // 
            this.addressTbox.Location = new System.Drawing.Point(166, 290);
            this.addressTbox.Name = "addressTbox";
            this.addressTbox.Size = new System.Drawing.Size(128, 20);
            this.addressTbox.TabIndex = 11;
            this.addressTbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTbox_Validating);
            // 
            // addressNumberTbox
            // 
            this.addressNumberTbox.Location = new System.Drawing.Point(166, 347);
            this.addressNumberTbox.Name = "addressNumberTbox";
            this.addressNumberTbox.Size = new System.Drawing.Size(128, 20);
            this.addressNumberTbox.TabIndex = 12;
            this.addressNumberTbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressNumberTbox_Validating);
            // 
            // addressAreaTbox
            // 
            this.addressAreaTbox.Location = new System.Drawing.Point(166, 397);
            this.addressAreaTbox.Name = "addressAreaTbox";
            this.addressAreaTbox.Size = new System.Drawing.Size(128, 20);
            this.addressAreaTbox.TabIndex = 13;
            this.addressAreaTbox.Validating += new System.ComponentModel.CancelEventHandler(this.addressAreaTbox_Validating);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(0, 42);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 42);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Coral;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Location = new System.Drawing.Point(0, 84);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(120, 42);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // customersLbl
            // 
            this.customersLbl.AutoSize = true;
            this.customersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.customersLbl.Location = new System.Drawing.Point(456, 20);
            this.customersLbl.Name = "customersLbl";
            this.customersLbl.Size = new System.Drawing.Size(109, 24);
            this.customersLbl.TabIndex = 16;
            this.customersLbl.Text = "Customers";
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ordersBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ordersBtn.FlatAppearance.BorderSize = 0;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersBtn.Location = new System.Drawing.Point(0, 217);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(120, 42);
            this.ordersBtn.TabIndex = 17;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseVisualStyleBackColor = false;
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.newOrderBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.newOrderBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newOrderBtn.FlatAppearance.BorderSize = 0;
            this.newOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newOrderBtn.Location = new System.Drawing.Point(0, 259);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(120, 42);
            this.newOrderBtn.TabIndex = 18;
            this.newOrderBtn.Text = "New Order";
            this.newOrderBtn.UseVisualStyleBackColor = false;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.closeBtn.Location = new System.Drawing.Point(752, 468);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 42);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sidebarMainPanel
            // 
            this.sidebarMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.sidebarMainPanel.Controls.Add(this.sidebarBtnPanel);
            this.sidebarMainPanel.Controls.Add(this.sidebarHeaderPanel);
            this.sidebarMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarMainPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarMainPanel.Name = "sidebarMainPanel";
            this.sidebarMainPanel.Size = new System.Drawing.Size(120, 561);
            this.sidebarMainPanel.TabIndex = 20;
            // 
            // sidebarBtnPanel
            // 
            this.sidebarBtnPanel.Controls.Add(this.clearBtn);
            this.sidebarBtnPanel.Controls.Add(this.deleteBtn);
            this.sidebarBtnPanel.Controls.Add(this.ordersBtn);
            this.sidebarBtnPanel.Controls.Add(this.newOrderBtn);
            this.sidebarBtnPanel.Controls.Add(this.saveOrEditBtn);
            this.sidebarBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarBtnPanel.Location = new System.Drawing.Point(0, 100);
            this.sidebarBtnPanel.Name = "sidebarBtnPanel";
            this.sidebarBtnPanel.Size = new System.Drawing.Size(120, 301);
            this.sidebarBtnPanel.TabIndex = 21;
            // 
            // sidebarHeaderPanel
            // 
            this.sidebarHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarHeaderPanel.Name = "sidebarHeaderPanel";
            this.sidebarHeaderPanel.Size = new System.Drawing.Size(120, 100);
            this.sidebarHeaderPanel.TabIndex = 0;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.sidebarMainPanel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.customersLbl);
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
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.sidebarMainPanel.ResumeLayout(false);
            this.sidebarBtnPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel sidebarMainPanel;
        private System.Windows.Forms.Panel sidebarBtnPanel;
        private System.Windows.Forms.Panel sidebarHeaderPanel;
    }
}