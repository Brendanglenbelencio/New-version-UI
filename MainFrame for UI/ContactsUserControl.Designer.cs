namespace MainFrame_for_UI
{
    partial class ContactsUserControl
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
            this.ContactsHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContactsHeader
            // 
            this.ContactsHeader.AutoSize = true;
            this.ContactsHeader.BackColor = System.Drawing.Color.Transparent;
            this.ContactsHeader.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsHeader.Location = new System.Drawing.Point(29, 32);
            this.ContactsHeader.Name = "ContactsHeader";
            this.ContactsHeader.Size = new System.Drawing.Size(607, 73);
            this.ContactsHeader.TabIndex = 3;
            this.ContactsHeader.Text = "CONTACTS SECTION";
            // 
            // ContactsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContactsHeader);
            this.Name = "ContactsUserControl";
            this.Size = new System.Drawing.Size(962, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsHeader;
    }
}
