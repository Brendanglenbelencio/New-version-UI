namespace MainFrame_for_UI
{
    partial class Form1
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
            this.BlackMainPanel = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LightGraySubPanel = new System.Windows.Forms.Panel();
            this.GraySubPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.BlackMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlackMainPanel
            // 
            this.BlackMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.BlackMainPanel.Controls.Add(this.Sidepanel);
            this.BlackMainPanel.Controls.Add(this.ContactsButton);
            this.BlackMainPanel.Controls.Add(this.EventsButton);
            this.BlackMainPanel.Controls.Add(this.ProductsButton);
            this.BlackMainPanel.Controls.Add(this.HomeButton);
            this.BlackMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BlackMainPanel.Location = new System.Drawing.Point(0, 0);
            this.BlackMainPanel.Name = "BlackMainPanel";
            this.BlackMainPanel.Size = new System.Drawing.Size(273, 720);
            this.BlackMainPanel.TabIndex = 0;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.White;
            this.Sidepanel.Location = new System.Drawing.Point(0, 147);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(28, 112);
            this.Sidepanel.TabIndex = 3;
            // 
            // ContactsButton
            // 
            this.ContactsButton.FlatAppearance.BorderSize = 0;
            this.ContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactsButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsButton.ForeColor = System.Drawing.Color.White;
            this.ContactsButton.Location = new System.Drawing.Point(43, 501);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(230, 112);
            this.ContactsButton.TabIndex = 3;
            this.ContactsButton.Text = "Contacts";
            this.ContactsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ContactsButton.UseVisualStyleBackColor = true;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.FlatAppearance.BorderSize = 0;
            this.EventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsButton.ForeColor = System.Drawing.Color.White;
            this.EventsButton.Location = new System.Drawing.Point(43, 383);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(230, 112);
            this.EventsButton.TabIndex = 2;
            this.EventsButton.Text = "Events";
            this.EventsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.White;
            this.ProductsButton.Location = new System.Drawing.Point(43, 265);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(230, 112);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(43, 147);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(230, 112);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LightGraySubPanel
            // 
            this.LightGraySubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.LightGraySubPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightGraySubPanel.Location = new System.Drawing.Point(273, 0);
            this.LightGraySubPanel.Name = "LightGraySubPanel";
            this.LightGraySubPanel.Size = new System.Drawing.Size(33, 720);
            this.LightGraySubPanel.TabIndex = 1;
            // 
            // GraySubPanel
            // 
            this.GraySubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(141)))));
            this.GraySubPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GraySubPanel.Location = new System.Drawing.Point(306, 0);
            this.GraySubPanel.Name = "GraySubPanel";
            this.GraySubPanel.Size = new System.Drawing.Size(33, 720);
            this.GraySubPanel.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.CloseButton.Location = new System.Drawing.Point(1179, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(122, 99);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Location = new System.Drawing.Point(339, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(962, 720);
            this.PanelContainer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.GraySubPanel);
            this.Controls.Add(this.LightGraySubPanel);
            this.Controls.Add(this.BlackMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BlackMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BlackMainPanel;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button ContactsButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel LightGraySubPanel;
        private System.Windows.Forms.Panel GraySubPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel PanelContainer;
    }
}

