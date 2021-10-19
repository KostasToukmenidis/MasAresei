
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.formTitlteLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // foodCategoryLbl
            // 
            this.foodCategoryLbl.AutoSize = true;
            this.foodCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryLbl.Location = new System.Drawing.Point(21, 133);
            this.foodCategoryLbl.Name = "foodCategoryLbl";
            this.foodCategoryLbl.Size = new System.Drawing.Size(73, 17);
            this.foodCategoryLbl.TabIndex = 0;
            this.foodCategoryLbl.Text = "Category";
            // 
            // foodCategoryTbox
            // 
            this.foodCategoryTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryTbox.Location = new System.Drawing.Point(12, 173);
            this.foodCategoryTbox.Name = "foodCategoryTbox";
            this.foodCategoryTbox.Size = new System.Drawing.Size(141, 23);
            this.foodCategoryTbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 289);
            this.dataGridView1.TabIndex = 2;
            // 
            // formTitlteLbl
            // 
            this.formTitlteLbl.AutoSize = true;
            this.formTitlteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.formTitlteLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.formTitlteLbl.Location = new System.Drawing.Point(325, 32);
            this.formTitlteLbl.Name = "formTitlteLbl";
            this.formTitlteLbl.Size = new System.Drawing.Size(150, 24);
            this.formTitlteLbl.TabIndex = 3;
            this.formTitlteLbl.Text = "Food Categories";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveBtn.Location = new System.Drawing.Point(12, 231);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 43);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(105, 231);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 43);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Coral;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Location = new System.Drawing.Point(195, 231);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 43);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // FoodCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.formTitlteLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.foodCategoryTbox);
            this.Controls.Add(this.foodCategoryLbl);
            this.Name = "FoodCategoryForm";
            this.Text = "FoodCategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodCategoryLbl;
        private System.Windows.Forms.TextBox foodCategoryTbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label formTitlteLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}