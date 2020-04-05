namespace MainFrame_for_UI
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.ShopTitle = new System.Windows.Forms.Label();
            this.ShopTagline = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopTitle
            // 
            this.ShopTitle.AutoSize = true;
            this.ShopTitle.BackColor = System.Drawing.Color.Transparent;
            this.ShopTitle.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopTitle.Location = new System.Drawing.Point(264, 147);
            this.ShopTitle.Name = "ShopTitle";
            this.ShopTitle.Size = new System.Drawing.Size(378, 73);
            this.ShopTitle.TabIndex = 0;
            this.ShopTitle.Text = "SHOP NAME";
            // 
            // ShopTagline
            // 
            this.ShopTagline.AutoSize = true;
            this.ShopTagline.BackColor = System.Drawing.Color.Transparent;
            this.ShopTagline.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopTagline.Location = new System.Drawing.Point(315, 235);
            this.ShopTagline.Name = "ShopTagline";
            this.ShopTagline.Size = new System.Drawing.Size(269, 73);
            this.ShopTagline.TabIndex = 1;
            this.ShopTagline.Text = "TAGLINE";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(345, 556);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(197, 54);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ShopTagline);
            this.Controls.Add(this.ShopTitle);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(962, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopTitle;
        private System.Windows.Forms.Label ShopTagline;
        private System.Windows.Forms.Button LoginButton;
    }
}
