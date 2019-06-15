using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellsManager.GUI
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            lblUsername.Text = Login.username;
            Sales products = new Sales();
            addToPanelControl(products);
        }

        private void moveSlidePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void addToPanelControl(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnSales);
            Sales products = new Sales();
            addToPanelControl(products);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnBilling);
            Bill bill = new Bill();
            addToPanelControl(bill);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnCustomers);
            Customers customers = new Customers();
            addToPanelControl(customers);
        }
    }
}
