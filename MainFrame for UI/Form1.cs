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
        public Button Contactbtn 
        {
            get { return ContactsButton; }
            set { ContactsButton = value; }
        }
        public Button Eventbtn 
        {
            get { return EventsButton; }
            set { EventsButton = value; }
        }

        public Button Productbtn 
        {
            get { return ProductsButton; }
            set { ProductsButton = value; }
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

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ProductsUserControl")) 
            {
                ProductsUserControl puc = new ProductsUserControl();
                puc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(puc);
            }
            Form1.Instance.PnlContainer.Controls["ProductsUserControl"].BringToFront();
            Form1.Instance.ProductsButton.Visible = true;
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("EventsUserControl")) 
            {
                EventsUserControl euc = new EventsUserControl();
                euc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(euc);
            }
            Form1.Instance.PnlContainer.Controls["EventsUserControl"].BringToFront();
            Form1.Instance.EventsButton.Visible = true;
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ContactsUserControl"))
            {
                ContactsUserControl cuc = new ContactsUserControl();
                cuc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(cuc);
            }
            Form1.Instance.PnlContainer.Controls["ContactsUserControl"].BringToFront();
            Form1.Instance.EventsButton.Visible = true;
        }
    }
}
