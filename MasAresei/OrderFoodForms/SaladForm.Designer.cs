
namespace MasAresei.OrderFoodForms
{
    partial class SaladForm
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
            this.agkourontomataRdBtn = new System.Windows.Forms.RadioButton();
            this.xoriatikiRdBtn = new System.Windows.Forms.RadioButton();
            this.cesarsRdBtn = new System.Windows.Forms.RadioButton();
            this.maroulosalataRdBtn = new System.Windows.Forms.RadioButton();
            this.cefsRdBtn = new System.Windows.Forms.RadioButton();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agkourontomataRdBtn
            // 
            this.agkourontomataRdBtn.AutoSize = true;
            this.agkourontomataRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.agkourontomataRdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agkourontomataRdBtn.Location = new System.Drawing.Point(52, 41);
            this.agkourontomataRdBtn.Name = "agkourontomataRdBtn";
            this.agkourontomataRdBtn.Size = new System.Drawing.Size(166, 28);
            this.agkourontomataRdBtn.TabIndex = 0;
            this.agkourontomataRdBtn.TabStop = true;
            this.agkourontomataRdBtn.Text = "Agkourontomata";
            this.agkourontomataRdBtn.UseVisualStyleBackColor = true;
            // 
            // xoriatikiRdBtn
            // 
            this.xoriatikiRdBtn.AutoSize = true;
            this.xoriatikiRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.xoriatikiRdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xoriatikiRdBtn.Location = new System.Drawing.Point(52, 87);
            this.xoriatikiRdBtn.Name = "xoriatikiRdBtn";
            this.xoriatikiRdBtn.Size = new System.Drawing.Size(94, 28);
            this.xoriatikiRdBtn.TabIndex = 1;
            this.xoriatikiRdBtn.TabStop = true;
            this.xoriatikiRdBtn.Text = "Xoriatiki";
            this.xoriatikiRdBtn.UseVisualStyleBackColor = true;
            // 
            // cesarsRdBtn
            // 
            this.cesarsRdBtn.AutoSize = true;
            this.cesarsRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cesarsRdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cesarsRdBtn.Location = new System.Drawing.Point(52, 131);
            this.cesarsRdBtn.Name = "cesarsRdBtn";
            this.cesarsRdBtn.Size = new System.Drawing.Size(86, 28);
            this.cesarsRdBtn.TabIndex = 2;
            this.cesarsRdBtn.TabStop = true;
            this.cesarsRdBtn.Text = "Cesars";
            this.cesarsRdBtn.UseVisualStyleBackColor = true;
            // 
            // maroulosalataRdBtn
            // 
            this.maroulosalataRdBtn.AutoSize = true;
            this.maroulosalataRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.maroulosalataRdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maroulosalataRdBtn.Location = new System.Drawing.Point(52, 180);
            this.maroulosalataRdBtn.Name = "maroulosalataRdBtn";
            this.maroulosalataRdBtn.Size = new System.Drawing.Size(144, 28);
            this.maroulosalataRdBtn.TabIndex = 3;
            this.maroulosalataRdBtn.TabStop = true;
            this.maroulosalataRdBtn.Text = "Maroulosalata";
            this.maroulosalataRdBtn.UseVisualStyleBackColor = true;
            // 
            // cefsRdBtn
            // 
            this.cefsRdBtn.AutoSize = true;
            this.cefsRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cefsRdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cefsRdBtn.Location = new System.Drawing.Point(52, 224);
            this.cefsRdBtn.Name = "cefsRdBtn";
            this.cefsRdBtn.Size = new System.Drawing.Size(65, 28);
            this.cefsRdBtn.TabIndex = 4;
            this.cefsRdBtn.TabStop = true;
            this.cefsRdBtn.Text = "Cefs";
            this.cefsRdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cefsRdBtn.UseVisualStyleBackColor = true;
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Location = new System.Drawing.Point(272, 116);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(116, 53);
            this.addToCartBtn.TabIndex = 5;
            this.addToCartBtn.Text = "Add to Cart";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // SaladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(456, 332);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.cefsRdBtn);
            this.Controls.Add(this.maroulosalataRdBtn);
            this.Controls.Add(this.cesarsRdBtn);
            this.Controls.Add(this.xoriatikiRdBtn);
            this.Controls.Add(this.agkourontomataRdBtn);
            this.Name = "SaladForm";
            this.Text = "SaladForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton agkourontomataRdBtn;
        private System.Windows.Forms.RadioButton xoriatikiRdBtn;
        private System.Windows.Forms.RadioButton cesarsRdBtn;
        private System.Windows.Forms.RadioButton maroulosalataRdBtn;
        private System.Windows.Forms.RadioButton cefsRdBtn;
        private System.Windows.Forms.Button addToCartBtn;
    }
}