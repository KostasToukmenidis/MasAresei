
namespace MasAresei
{
    partial class FoodCategoryForm
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
            this.foodCategoryLbl = new System.Windows.Forms.Label();
            this.foodCategoryTbox = new System.Windows.Forms.TextBox();
            this.foodCategoryGrid = new System.Windows.Forms.DataGridView();
            this.formTitlteLbl = new System.Windows.Forms.Label();
            this.saveOrEditBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodCategoryLbl
            // 
            this.foodCategoryLbl.AutoSize = true;
            this.foodCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodCategoryLbl.Location = new System.Drawing.Point(160, 166);
            this.foodCategoryLbl.Name = "foodCategoryLbl";
            this.foodCategoryLbl.Size = new System.Drawing.Size(73, 17);
            this.foodCategoryLbl.TabIndex = 0;
            this.foodCategoryLbl.Text = "Category";
            // 
            // foodCategoryTbox
            // 
            this.foodCategoryTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryTbox.Location = new System.Drawing.Point(163, 186);
            this.foodCategoryTbox.Name = "foodCategoryTbox";
            this.foodCategoryTbox.Size = new System.Drawing.Size(141, 23);
            this.foodCategoryTbox.TabIndex = 1;
            this.foodCategoryTbox.Validating += new System.ComponentModel.CancelEventHandler(this.foodCategoryTbox_Validating);
            // 
            // foodCategoryGrid
            // 
            this.foodCategoryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodCategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodCategoryGrid.Location = new System.Drawing.Point(416, 136);
            this.foodCategoryGrid.Name = "foodCategoryGrid";
            this.foodCategoryGrid.Size = new System.Drawing.Size(403, 289);
            this.foodCategoryGrid.TabIndex = 2;
            this.foodCategoryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodCategoryGrid_CellClick);
            // 
            // formTitlteLbl
            // 
            this.formTitlteLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formTitlteLbl.AutoSize = true;
            this.formTitlteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.formTitlteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.formTitlteLbl.Location = new System.Drawing.Point(353, 21);
            this.formTitlteLbl.Name = "formTitlteLbl";
            this.formTitlteLbl.Size = new System.Drawing.Size(150, 24);
            this.formTitlteLbl.TabIndex = 3;
            this.formTitlteLbl.Text = "Food Categories";
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
            this.saveOrEditBtn.Size = new System.Drawing.Size(120, 43);
            this.saveOrEditBtn.TabIndex = 4;
            this.saveOrEditBtn.Text = "Save";
            this.saveOrEditBtn.UseVisualStyleBackColor = false;
            this.saveOrEditBtn.Click += new System.EventHandler(this.saveOrEditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(0, 86);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 43);
            this.deleteBtn.TabIndex = 5;
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
            this.clearBtn.Location = new System.Drawing.Point(0, 43);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(120, 43);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Coral;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtn.Location = new System.Drawing.Point(744, 431);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 43);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 600);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.clearBtn);
            this.panel3.Controls.Add(this.saveOrEditBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 252);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 100);
            this.panel2.TabIndex = 9;
            // 
            // FoodCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.formTitlteLbl);
            this.Controls.Add(this.foodCategoryGrid);
            this.Controls.Add(this.foodCategoryTbox);
            this.Controls.Add(this.foodCategoryLbl);
            this.Name = "FoodCategoryForm";
            this.Text = "FoodCategoryForm";
            this.Load += new System.EventHandler(this.FoodCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodCategoryLbl;
        private System.Windows.Forms.TextBox foodCategoryTbox;
        private System.Windows.Forms.DataGridView foodCategoryGrid;
        private System.Windows.Forms.Label formTitlteLbl;
        private System.Windows.Forms.Button saveOrEditBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}