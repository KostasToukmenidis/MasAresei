
namespace MasAresei
{
    partial class FoodForm
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
            this.foodTitleLbl = new System.Windows.Forms.Label();
            this.sidebarMainPanel = new System.Windows.Forms.Panel();
            this.sidebarBtnPanel = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveOrEditBtn = new System.Windows.Forms.Button();
            this.sidebarHeaderPanel = new System.Windows.Forms.Panel();
            this.foodGrid = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.foodNameLbl = new System.Windows.Forms.Label();
            this.foodPriceLbl = new System.Windows.Forms.Label();
            this.foodCategoryLbl = new System.Windows.Forms.Label();
            this.foodNameTbox = new System.Windows.Forms.TextBox();
            this.foodPriceTbox = new System.Windows.Forms.TextBox();
            this.foodCategoryCmbBox = new System.Windows.Forms.ComboBox();
            this.sidebarMainPanel.SuspendLayout();
            this.sidebarBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // foodTitleLbl
            // 
            this.foodTitleLbl.AutoSize = true;
            this.foodTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodTitleLbl.Location = new System.Drawing.Point(568, 30);
            this.foodTitleLbl.Name = "foodTitleLbl";
            this.foodTitleLbl.Size = new System.Drawing.Size(50, 20);
            this.foodTitleLbl.TabIndex = 0;
            this.foodTitleLbl.Text = "Food";
            // 
            // sidebarMainPanel
            // 
            this.sidebarMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.sidebarMainPanel.Controls.Add(this.sidebarBtnPanel);
            this.sidebarMainPanel.Controls.Add(this.sidebarHeaderPanel);
            this.sidebarMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarMainPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarMainPanel.Name = "sidebarMainPanel";
            this.sidebarMainPanel.Size = new System.Drawing.Size(160, 600);
            this.sidebarMainPanel.TabIndex = 1;
            // 
            // sidebarBtnPanel
            // 
            this.sidebarBtnPanel.Controls.Add(this.clearBtn);
            this.sidebarBtnPanel.Controls.Add(this.deleteBtn);
            this.sidebarBtnPanel.Controls.Add(this.saveOrEditBtn);
            this.sidebarBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarBtnPanel.Location = new System.Drawing.Point(0, 123);
            this.sidebarBtnPanel.Name = "sidebarBtnPanel";
            this.sidebarBtnPanel.Size = new System.Drawing.Size(160, 331);
            this.sidebarBtnPanel.TabIndex = 8;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Coral;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Location = new System.Drawing.Point(0, 102);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(160, 51);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(0, 51);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 51);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.saveOrEditBtn.Size = new System.Drawing.Size(160, 51);
            this.saveOrEditBtn.TabIndex = 6;
            this.saveOrEditBtn.Text = "Save";
            this.saveOrEditBtn.UseVisualStyleBackColor = false;
            this.saveOrEditBtn.Click += new System.EventHandler(this.saveOrEditBtn_Click);
            // 
            // sidebarHeaderPanel
            // 
            this.sidebarHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarHeaderPanel.Name = "sidebarHeaderPanel";
            this.sidebarHeaderPanel.Size = new System.Drawing.Size(160, 123);
            this.sidebarHeaderPanel.TabIndex = 7;
            // 
            // foodGrid
            // 
            this.foodGrid.AllowUserToAddRows = false;
            this.foodGrid.AllowUserToDeleteRows = false;
            this.foodGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGrid.Location = new System.Drawing.Point(451, 151);
            this.foodGrid.MultiSelect = false;
            this.foodGrid.Name = "foodGrid";
            this.foodGrid.ReadOnly = true;
            this.foodGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodGrid.Size = new System.Drawing.Size(431, 265);
            this.foodGrid.TabIndex = 2;
            this.foodGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodGrid_CellClick);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.closeBtn.Location = new System.Drawing.Point(724, 448);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(160, 51);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // foodNameLbl
            // 
            this.foodNameLbl.AutoSize = true;
            this.foodNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodNameLbl.Location = new System.Drawing.Point(241, 154);
            this.foodNameLbl.Name = "foodNameLbl";
            this.foodNameLbl.Size = new System.Drawing.Size(49, 17);
            this.foodNameLbl.TabIndex = 4;
            this.foodNameLbl.Text = "Name";
            // 
            // foodPriceLbl
            // 
            this.foodPriceLbl.AutoSize = true;
            this.foodPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodPriceLbl.Location = new System.Drawing.Point(241, 218);
            this.foodPriceLbl.Name = "foodPriceLbl";
            this.foodPriceLbl.Size = new System.Drawing.Size(45, 17);
            this.foodPriceLbl.TabIndex = 5;
            this.foodPriceLbl.Text = "Price";
            // 
            // foodCategoryLbl
            // 
            this.foodCategoryLbl.AutoSize = true;
            this.foodCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodCategoryLbl.Location = new System.Drawing.Point(241, 285);
            this.foodCategoryLbl.Name = "foodCategoryLbl";
            this.foodCategoryLbl.Size = new System.Drawing.Size(73, 17);
            this.foodCategoryLbl.TabIndex = 6;
            this.foodCategoryLbl.Text = "Category";
            // 
            // foodNameTbox
            // 
            this.foodNameTbox.Location = new System.Drawing.Point(246, 178);
            this.foodNameTbox.Name = "foodNameTbox";
            this.foodNameTbox.Size = new System.Drawing.Size(132, 23);
            this.foodNameTbox.TabIndex = 7;
            this.foodNameTbox.Validating += new System.ComponentModel.CancelEventHandler(this.foodNameTbox_Validating);
            // 
            // foodPriceTbox
            // 
            this.foodPriceTbox.Location = new System.Drawing.Point(246, 242);
            this.foodPriceTbox.Name = "foodPriceTbox";
            this.foodPriceTbox.Size = new System.Drawing.Size(132, 23);
            this.foodPriceTbox.TabIndex = 8;
            this.foodPriceTbox.Validating += new System.ComponentModel.CancelEventHandler(this.foodPriceTbox_Validating);
            // 
            // foodCategoryCmbBox
            // 
            this.foodCategoryCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryCmbBox.FormattingEnabled = true;
            this.foodCategoryCmbBox.Location = new System.Drawing.Point(246, 305);
            this.foodCategoryCmbBox.Name = "foodCategoryCmbBox";
            this.foodCategoryCmbBox.Size = new System.Drawing.Size(132, 23);
            this.foodCategoryCmbBox.TabIndex = 11;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.foodCategoryCmbBox);
            this.Controls.Add(this.foodPriceTbox);
            this.Controls.Add(this.foodNameTbox);
            this.Controls.Add(this.foodCategoryLbl);
            this.Controls.Add(this.foodPriceLbl);
            this.Controls.Add(this.foodNameLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.foodGrid);
            this.Controls.Add(this.sidebarMainPanel);
            this.Controls.Add(this.foodTitleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            this.sidebarMainPanel.ResumeLayout(false);
            this.sidebarBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodTitleLbl;
        private System.Windows.Forms.Panel sidebarMainPanel;
        private System.Windows.Forms.DataGridView foodGrid;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveOrEditBtn;
        private System.Windows.Forms.Panel sidebarBtnPanel;
        private System.Windows.Forms.Panel sidebarHeaderPanel;
        private System.Windows.Forms.Label foodNameLbl;
        private System.Windows.Forms.Label foodPriceLbl;
        private System.Windows.Forms.Label foodCategoryLbl;
        private System.Windows.Forms.TextBox foodNameTbox;
        private System.Windows.Forms.TextBox foodPriceTbox;
        private System.Windows.Forms.ComboBox foodCategoryCmbBox;
    }
}