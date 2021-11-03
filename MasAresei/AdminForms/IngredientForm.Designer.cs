
namespace MasAresei
{
    partial class IngredientForm
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
            this.ingredientsLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveOrEditBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ingredientTbox = new System.Windows.Forms.TextBox();
            this.ingredientGrid = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientsLbl
            // 
            this.ingredientsLbl.AutoSize = true;
            this.ingredientsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ingredientsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ingredientsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.ingredientsLbl.Location = new System.Drawing.Point(412, 35);
            this.ingredientsLbl.Name = "ingredientsLbl";
            this.ingredientsLbl.Size = new System.Drawing.Size(114, 24);
            this.ingredientsLbl.TabIndex = 0;
            this.ingredientsLbl.Text = "Ingredients";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.nameLbl.Location = new System.Drawing.Point(160, 166);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 17);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 600);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.saveOrEditBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 274);
            this.panel2.TabIndex = 3;
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
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.saveOrEditBtn.TabIndex = 3;
            this.saveOrEditBtn.Text = "Save";
            this.saveOrEditBtn.UseVisualStyleBackColor = false;
            this.saveOrEditBtn.Click += new System.EventHandler(this.saveOrEditBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 100);
            this.panel3.TabIndex = 4;
            // 
            // ingredientTbox
            // 
            this.ingredientTbox.Location = new System.Drawing.Point(163, 186);
            this.ingredientTbox.Name = "ingredientTbox";
            this.ingredientTbox.Size = new System.Drawing.Size(141, 20);
            this.ingredientTbox.TabIndex = 3;
            // 
            // ingredientGrid
            // 
            this.ingredientGrid.AllowUserToAddRows = false;
            this.ingredientGrid.AllowUserToDeleteRows = false;
            this.ingredientGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientGrid.Location = new System.Drawing.Point(416, 136);
            this.ingredientGrid.MultiSelect = false;
            this.ingredientGrid.Name = "ingredientGrid";
            this.ingredientGrid.ReadOnly = true;
            this.ingredientGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ingredientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientGrid.Size = new System.Drawing.Size(403, 289);
            this.ingredientGrid.TabIndex = 4;
            this.ingredientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredientGrid_CellClick);
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
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.priceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.priceLbl.Location = new System.Drawing.Point(160, 222);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(45, 17);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "Price";
            // 
            // priceTbox
            // 
            this.priceTbox.Location = new System.Drawing.Point(163, 242);
            this.priceTbox.Name = "priceTbox";
            this.priceTbox.Size = new System.Drawing.Size(141, 20);
            this.priceTbox.TabIndex = 7;
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.priceTbox);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ingredientGrid);
            this.Controls.Add(this.ingredientTbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.ingredientsLbl);
            this.Name = "IngredientForm";
            this.Text = "IngredientForm";
            this.Load += new System.EventHandler(this.IngredientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ingredientsLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveOrEditBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox ingredientTbox;
        private System.Windows.Forms.DataGridView ingredientGrid;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTbox;
    }
}