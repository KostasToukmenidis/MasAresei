
namespace MasAresei
{
    partial class NewOrderForm
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
            this.saladBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saladBtn
            // 
            this.saladBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saladBtn.Location = new System.Drawing.Point(35, 36);
            this.saladBtn.Name = "saladBtn";
            this.saladBtn.Size = new System.Drawing.Size(234, 78);
            this.saladBtn.TabIndex = 0;
            this.saladBtn.Text = "Salad";
            this.saladBtn.UseVisualStyleBackColor = false;
            this.saladBtn.Click += new System.EventHandler(this.saladBtn_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saladBtn);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saladBtn;
    }
}