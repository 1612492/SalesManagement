using SellsManager.BUS;
using SellsManager.DTO;
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
    public partial class Login : Form
    {
        Login_BUS login_BUS = new Login_BUS();
        public static string username;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_DTO login_DTO = new Login_DTO(txtUsername.Text, txtPassword.Text);
            username = txtUsername.Text;

            if(login_BUS.getPosition(login_DTO) == "Seller")
            {
                Seller seller = new Seller();
                this.Hide();
                seller.ShowDialog();
                this.Show();
            }
            else if(login_BUS.getPosition(login_DTO) == "Manager")
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
