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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lblUsername.Text = Login.username;
            Category category = new Category();
            addToPanelControl(category);
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

        private void btnCategory_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnCategory);
            Category category = new Category();
            addToPanelControl(category);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnProducts);
            Products products = new Products();
            addToPanelControl(products);
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnProviders);
            Provider provider = new Provider();
            addToPanelControl(provider);
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnPromotion);
            Promotion promotion = new Promotion();
            addToPanelControl(promotion);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnStatistic);
            Statistics statistics = new Statistics();
            addToPanelControl(statistics);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnAccount);
            Account account = new Account();
            addToPanelControl(account);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
