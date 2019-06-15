using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SellsManager.BUS;
using SellsManager.DTO;

namespace SellsManager.GUI
{
    public partial class Account : UserControl
    {
        Account_BUS account_BUS = new Account_BUS();
        public static string id;
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            grvAccount.DataSource = account_BUS.Load();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Account_DTO account_DTO = new Account_DTO(0, txtName.Text, cbbGender.SelectedItem.ToString(),
                dtpBirthday.Value.ToString("yyyy-MM-dd"),txtAddress.Text,txtIdCard.Text,txtPhone.Text,
                dtpStartWoking.Value.ToString("yyyy-MM-dd"),cbbRole.SelectedItem.ToString(),txtUsername.Text,txtPassword.Text);
            if (account_BUS.New(account_DTO))
            {
                grvAccount.DataSource = account_BUS.Load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Account_DTO account_DTO = new Account_DTO(ID, txtName.Text, cbbGender.SelectedItem.ToString(),
                dtpBirthday.Value.ToString("yyyy-MM-dd"), txtAddress.Text, txtIdCard.Text, txtPhone.Text,
                dtpStartWoking.Value.ToString("yyyy-MM-dd"), cbbRole.SelectedItem.ToString(), txtUsername.Text, txtPassword.Text);
            if (account_BUS.Edit(account_DTO))
            {
                grvAccount.DataSource = account_BUS.Load();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            if (account_BUS.Delete(ID))
            {
                grvAccount.DataSource = account_BUS.Load();
            }
        }

        private void grvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grvAccount.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                cbbGender.SelectedItem = row.Cells["gender"].Value.ToString();
                dtpBirthday.Value = (DateTime)row.Cells["birthday"].Value;
                txtAddress.Text = row.Cells["addr"].Value.ToString();
                txtIdCard.Text = row.Cells["idCard"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                dtpStartWoking.Value = (DateTime)row.Cells["startWorking"].Value;
                cbbRole.SelectedItem = row.Cells["position"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["pass"].Value.ToString();
            }
        }
    }
}
