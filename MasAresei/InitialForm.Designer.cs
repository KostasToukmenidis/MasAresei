
namespace MasAresei
{
    partial class InitialForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.testsBtn = new System.Windows.Forms.Button();
            this.customersWnd = new System.Windows.Forms.Button();
            this.foodCategoryWindowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.titleLbl.Location = new System.Drawing.Point(304, 30);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(180, 26);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Mas Aresei App";
            // 
            // testsBtn
            // 
            this.testsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testsBtn.Location = new System.Drawing.Point(95, 124);
            this.testsBtn.Name = "testsBtn";
            this.testsBtn.Size = new System.Drawing.Size(113, 39);
            this.testsBtn.TabIndex = 1;
            this.testsBtn.Text = "Tests";
            this.testsBtn.UseVisualStyleBackColor = true;
            // 
            // customersWnd
            // 
            this.customersWnd.BackColor = System.Drawing.Color.SteelBlue;
            this.customersWnd.Location = new System.Drawing.Point(244, 124);
            this.customersWnd.Name = "customersWnd";
            this.customersWnd.Size = new System.Drawing.Size(98, 39);
            this.customersWnd.TabIndex = 2;
            this.customersWnd.Text = "Customers Window";
            this.customersWnd.UseVisualStyleBackColor = false;
            this.customersWnd.Click += new System.EventHandler(this.customersWnd_Click);
            // 
            // foodCategoryWindowBtn
            // 
            this.foodCategoryWindowBtn.BackColor = System.Drawing.Color.Teal;
            this.foodCategoryWindowBtn.Location = new System.Drawing.Point(386, 124);
            this.foodCategoryWindowBtn.Name = "foodCategoryWindowBtn";
            this.foodCategoryWindowBtn.Size = new System.Drawing.Size(98, 39);
            this.foodCategoryWindowBtn.TabIndex = 3;
            this.foodCategoryWindowBtn.Text = "Add Food Category";
            this.foodCategoryWindowBtn.UseVisualStyleBackColor = false;
            this.foodCategoryWindowBtn.Click += new System.EventHandler(this.foodCategoryWindowBtn_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foodCategoryWindowBtn);
            this.Controls.Add(this.customersWnd);
            this.Controls.Add(this.testsBtn);
            this.Controls.Add(this.titleLbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button testsBtn;
        private System.Windows.Forms.Button customersWnd;
        private System.Windows.Forms.Button foodCategoryWindowBtn;
    }
}

