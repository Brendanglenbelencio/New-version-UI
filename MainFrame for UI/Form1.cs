using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame_for_UI
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance 
        {
            get 
            {
                if (_obj == null) 
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        
        public Panel PnlContainer 
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }
        
        public Button Homebtn 
        {
            get { return HomeButton; }
            set { HomeButton = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HomeButton.Visible = true;
            _obj = this;

            HomeUserControl huc = new HomeUserControl();
            huc.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(huc);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls["HomeUserControl"].BringToFront();
            HomeButton.Visible = true;
        }
    }
}
