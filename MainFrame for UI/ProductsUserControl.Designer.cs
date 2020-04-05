namespace MainFrame_for_UI
{
    partial class ProductsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductsHeader
            // 
            this.ProductsHeader.AutoSize = true;
            this.ProductsHeader.BackColor = System.Drawing.Color.Transparent;
            this.ProductsHeader.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsHeader.Location = new System.Drawing.Point(30, 35);
            this.ProductsHeader.Name = "ProductsHeader";
            this.ProductsHeader.Size = new System.Drawing.Size(596, 73);
            this.ProductsHeader.TabIndex = 1;
            this.ProductsHeader.Text = "PRODUCTS SECTION";
            // 
            // ProductsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductsHeader);
            this.Name = "ProductsUserControl";
            this.Size = new System.Drawing.Size(962, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsHeader;
    }
}
