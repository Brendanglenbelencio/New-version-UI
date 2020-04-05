namespace MainFrame_for_UI
{
    partial class EventsUserControl
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
            this.EventsHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventsHeader
            // 
            this.EventsHeader.AutoSize = true;
            this.EventsHeader.BackColor = System.Drawing.Color.Transparent;
            this.EventsHeader.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsHeader.Location = new System.Drawing.Point(54, 34);
            this.EventsHeader.Name = "EventsHeader";
            this.EventsHeader.Size = new System.Drawing.Size(498, 73);
            this.EventsHeader.TabIndex = 2;
            this.EventsHeader.Text = "EVENTS SECTION";
            // 
            // EventsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventsHeader);
            this.Name = "EventsUserControl";
            this.Size = new System.Drawing.Size(962, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventsHeader;
    }
}
