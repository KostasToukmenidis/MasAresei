
namespace MasAresei
{
    partial class CustomersOrdersForm
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
            this.ordersHeadLineLbl = new System.Windows.Forms.Label();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersHeadLineLbl
            // 
            this.ordersHeadLineLbl.AutoSize = true;
            this.ordersHeadLineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ordersHeadLineLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.ordersHeadLineLbl.Location = new System.Drawing.Point(364, 9);
            this.ordersHeadLineLbl.Name = "ordersHeadLineLbl";
            this.ordersHeadLineLbl.Size = new System.Drawing.Size(74, 24);
            this.ordersHeadLineLbl.TabIndex = 0;
            this.ordersHeadLineLbl.Text = "Orders";
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(12, 36);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new System.Drawing.Size(776, 402);
            this.ordersGrid.TabIndex = 1;
            // 
            // CustomersOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.ordersHeadLineLbl);
            this.Name = "CustomersOrders";
            this.Text = "CustomersOrders";
            this.Load += new System.EventHandler(this.CustomersOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordersHeadLineLbl;
        private System.Windows.Forms.DataGridView ordersGrid;
    }
}