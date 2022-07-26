namespace Sqlite.Database.Connection.Forms
{
    partial class InvoiceDetail
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
            this.grdInvoice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInvoice
            // 
            this.grdInvoice.AllowUserToAddRows = false;
            this.grdInvoice.AllowUserToDeleteRows = false;
            this.grdInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInvoice.Location = new System.Drawing.Point(0, 0);
            this.grdInvoice.Name = "grdInvoice";
            this.grdInvoice.ReadOnly = true;
            this.grdInvoice.RowHeadersWidth = 51;
            this.grdInvoice.RowTemplate.Height = 24;
            this.grdInvoice.Size = new System.Drawing.Size(534, 430);
            this.grdInvoice.TabIndex = 0;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 430);
            this.Controls.Add(this.grdInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Bilgileri";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInvoice;
    }
}