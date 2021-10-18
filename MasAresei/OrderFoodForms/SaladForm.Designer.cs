
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
            this.Xoriatiki = new System.Windows.Forms.RadioButton();
            this.Cesars = new System.Windows.Forms.RadioButton();
            this.Maroulosalata = new System.Windows.Forms.RadioButton();
            this.Cefs = new System.Windows.Forms.RadioButton();
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
            this.agkourontomataRdBtn.CheckedChanged += new System.EventHandler(this.agkourontomataRdBtn_CheckedChanged);
            // 
            // Xoriatiki
            // 
            this.Xoriatiki.AutoSize = true;
            this.Xoriatiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Xoriatiki.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Xoriatiki.Location = new System.Drawing.Point(52, 87);
            this.Xoriatiki.Name = "Xoriatiki";
            this.Xoriatiki.Size = new System.Drawing.Size(94, 28);
            this.Xoriatiki.TabIndex = 1;
            this.Xoriatiki.TabStop = true;
            this.Xoriatiki.Text = "Xoriatiki";
            this.Xoriatiki.UseVisualStyleBackColor = true;
            // 
            // Cesars
            // 
            this.Cesars.AutoSize = true;
            this.Cesars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Cesars.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cesars.Location = new System.Drawing.Point(52, 131);
            this.Cesars.Name = "Cesars";
            this.Cesars.Size = new System.Drawing.Size(86, 28);
            this.Cesars.TabIndex = 2;
            this.Cesars.TabStop = true;
            this.Cesars.Text = "Cesars";
            this.Cesars.UseVisualStyleBackColor = true;
            // 
            // Maroulosalata
            // 
            this.Maroulosalata.AutoSize = true;
            this.Maroulosalata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Maroulosalata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Maroulosalata.Location = new System.Drawing.Point(52, 180);
            this.Maroulosalata.Name = "Maroulosalata";
            this.Maroulosalata.Size = new System.Drawing.Size(144, 28);
            this.Maroulosalata.TabIndex = 3;
            this.Maroulosalata.TabStop = true;
            this.Maroulosalata.Text = "Maroulosalata";
            this.Maroulosalata.UseVisualStyleBackColor = true;
            // 
            // Cefs
            // 
            this.Cefs.AutoSize = true;
            this.Cefs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Cefs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cefs.Location = new System.Drawing.Point(52, 224);
            this.Cefs.Name = "Cefs";
            this.Cefs.Size = new System.Drawing.Size(65, 28);
            this.Cefs.TabIndex = 4;
            this.Cefs.TabStop = true;
            this.Cefs.Text = "Cefs";
            this.Cefs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cefs.UseVisualStyleBackColor = true;
            // 
            // SaladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(456, 332);
            this.Controls.Add(this.Cefs);
            this.Controls.Add(this.Maroulosalata);
            this.Controls.Add(this.Cesars);
            this.Controls.Add(this.Xoriatiki);
            this.Controls.Add(this.agkourontomataRdBtn);
            this.Name = "SaladForm";
            this.Text = "SaladForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton agkourontomataRdBtn;
        private System.Windows.Forms.RadioButton Xoriatiki;
        private System.Windows.Forms.RadioButton Cesars;
        private System.Windows.Forms.RadioButton Maroulosalata;
        private System.Windows.Forms.RadioButton Cefs;
    }
}