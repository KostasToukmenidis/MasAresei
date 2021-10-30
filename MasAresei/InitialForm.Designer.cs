
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.testsBtn = new System.Windows.Forms.Button();
            this.customersWindowBtn = new System.Windows.Forms.Button();
            this.foodCategoryWindowBtn = new System.Windows.Forms.Button();
            this.sideBarMainPanel = new System.Windows.Forms.Panel();
            this.sideBarBtnPanel = new System.Windows.Forms.Panel();
            this.foodWindowBtn = new System.Windows.Forms.Button();
            this.sideBarHeaderPanel = new System.Windows.Forms.Panel();
            this.mainFormsPanel = new System.Windows.Forms.Panel();
            this.mainFormPictureBox = new System.Windows.Forms.PictureBox();
            this.ingredientsWindowBtn = new System.Windows.Forms.Button();
            this.sideBarMainPanel.SuspendLayout();
            this.sideBarBtnPanel.SuspendLayout();
            this.mainFormsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // testsBtn
            // 
            this.testsBtn.BackColor = System.Drawing.Color.White;
            this.testsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testsBtn.Location = new System.Drawing.Point(0, 552);
            this.testsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.testsBtn.Name = "testsBtn";
            this.testsBtn.Size = new System.Drawing.Size(250, 48);
            this.testsBtn.TabIndex = 1;
            this.testsBtn.Text = "Tests";
            this.testsBtn.UseVisualStyleBackColor = false;
            // 
            // customersWindowBtn
            // 
            this.customersWindowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.customersWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersWindowBtn.FlatAppearance.BorderSize = 0;
            this.customersWindowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.customersWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersWindowBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customersWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.customersWindowBtn.Location = new System.Drawing.Point(0, 0);
            this.customersWindowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.customersWindowBtn.Name = "customersWindowBtn";
            this.customersWindowBtn.Size = new System.Drawing.Size(250, 86);
            this.customersWindowBtn.TabIndex = 2;
            this.customersWindowBtn.Text = "Customers Window";
            this.customersWindowBtn.UseVisualStyleBackColor = false;
            this.customersWindowBtn.Click += new System.EventHandler(this.customersWnd_Click);
            // 
            // foodCategoryWindowBtn
            // 
            this.foodCategoryWindowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.foodCategoryWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodCategoryWindowBtn.FlatAppearance.BorderSize = 0;
            this.foodCategoryWindowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.foodCategoryWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodCategoryWindowBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodCategoryWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodCategoryWindowBtn.Location = new System.Drawing.Point(0, 86);
            this.foodCategoryWindowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.foodCategoryWindowBtn.Name = "foodCategoryWindowBtn";
            this.foodCategoryWindowBtn.Size = new System.Drawing.Size(250, 91);
            this.foodCategoryWindowBtn.TabIndex = 3;
            this.foodCategoryWindowBtn.Text = "Add Food Category";
            this.foodCategoryWindowBtn.UseVisualStyleBackColor = false;
            this.foodCategoryWindowBtn.Click += new System.EventHandler(this.foodCategoryWindowBtn_Click);
            // 
            // sideBarMainPanel
            // 
            this.sideBarMainPanel.AutoScroll = true;
            this.sideBarMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.sideBarMainPanel.Controls.Add(this.sideBarBtnPanel);
            this.sideBarMainPanel.Controls.Add(this.sideBarHeaderPanel);
            this.sideBarMainPanel.Controls.Add(this.testsBtn);
            this.sideBarMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarMainPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarMainPanel.Name = "sideBarMainPanel";
            this.sideBarMainPanel.Size = new System.Drawing.Size(250, 600);
            this.sideBarMainPanel.TabIndex = 4;
            // 
            // sideBarBtnPanel
            // 
            this.sideBarBtnPanel.Controls.Add(this.ingredientsWindowBtn);
            this.sideBarBtnPanel.Controls.Add(this.foodWindowBtn);
            this.sideBarBtnPanel.Controls.Add(this.foodCategoryWindowBtn);
            this.sideBarBtnPanel.Controls.Add(this.customersWindowBtn);
            this.sideBarBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarBtnPanel.Location = new System.Drawing.Point(0, 87);
            this.sideBarBtnPanel.Name = "sideBarBtnPanel";
            this.sideBarBtnPanel.Size = new System.Drawing.Size(250, 377);
            this.sideBarBtnPanel.TabIndex = 4;
            // 
            // foodWindowBtn
            // 
            this.foodWindowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.foodWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodWindowBtn.FlatAppearance.BorderSize = 0;
            this.foodWindowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.foodWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodWindowBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.foodWindowBtn.Location = new System.Drawing.Point(0, 177);
            this.foodWindowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.foodWindowBtn.Name = "foodWindowBtn";
            this.foodWindowBtn.Size = new System.Drawing.Size(250, 91);
            this.foodWindowBtn.TabIndex = 4;
            this.foodWindowBtn.Text = "Add Food";
            this.foodWindowBtn.UseVisualStyleBackColor = false;
            this.foodWindowBtn.Click += new System.EventHandler(this.foodWindowBtn_Click);
            // 
            // sideBarHeaderPanel
            // 
            this.sideBarHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarHeaderPanel.Name = "sideBarHeaderPanel";
            this.sideBarHeaderPanel.Size = new System.Drawing.Size(250, 87);
            this.sideBarHeaderPanel.TabIndex = 0;
            // 
            // mainFormsPanel
            // 
            this.mainFormsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.mainFormsPanel.Controls.Add(this.mainFormPictureBox);
            this.mainFormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormsPanel.Location = new System.Drawing.Point(250, 0);
            this.mainFormsPanel.Name = "mainFormsPanel";
            this.mainFormsPanel.Size = new System.Drawing.Size(1194, 600);
            this.mainFormsPanel.TabIndex = 5;
            // 
            // mainFormPictureBox
            // 
            this.mainFormPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainFormPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mainFormPictureBox.Image")));
            this.mainFormPictureBox.Location = new System.Drawing.Point(75, 112);
            this.mainFormPictureBox.Name = "mainFormPictureBox";
            this.mainFormPictureBox.Size = new System.Drawing.Size(1056, 331);
            this.mainFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainFormPictureBox.TabIndex = 1;
            this.mainFormPictureBox.TabStop = false;
            // 
            // ingredientsWindowBtn
            // 
            this.ingredientsWindowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ingredientsWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ingredientsWindowBtn.FlatAppearance.BorderSize = 0;
            this.ingredientsWindowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ingredientsWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredientsWindowBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ingredientsWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(162)))), ((int)(((byte)(90)))));
            this.ingredientsWindowBtn.Location = new System.Drawing.Point(0, 268);
            this.ingredientsWindowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ingredientsWindowBtn.Name = "ingredientsWindowBtn";
            this.ingredientsWindowBtn.Size = new System.Drawing.Size(250, 86);
            this.ingredientsWindowBtn.TabIndex = 5;
            this.ingredientsWindowBtn.Text = "Add an Ingredient";
            this.ingredientsWindowBtn.UseVisualStyleBackColor = false;
            this.ingredientsWindowBtn.Click += new System.EventHandler(this.ingredientsWindowBtn_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1444, 600);
            this.Controls.Add(this.mainFormsPanel);
            this.Controls.Add(this.sideBarMainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitialForm";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.sideBarMainPanel.ResumeLayout(false);
            this.sideBarBtnPanel.ResumeLayout(false);
            this.mainFormsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button testsBtn;
        private System.Windows.Forms.Button customersWindowBtn;
        private System.Windows.Forms.Button foodCategoryWindowBtn;
        private System.Windows.Forms.Panel sideBarMainPanel;
        private System.Windows.Forms.Panel sideBarBtnPanel;
        private System.Windows.Forms.Panel sideBarHeaderPanel;
        private System.Windows.Forms.Panel mainFormsPanel;
        private System.Windows.Forms.PictureBox mainFormPictureBox;
        private System.Windows.Forms.Button foodWindowBtn;
        private System.Windows.Forms.Button ingredientsWindowBtn;
    }
}

