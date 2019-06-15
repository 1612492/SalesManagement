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
    public partial class Provider : UserControl
    {
        Provider_BUS provider_BUS = new Provider_BUS();
        public static string id;
        public Provider()
        {
            InitializeComponent();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            grvProvider.DataSource = provider_BUS.Load();
            cbbProduct.DataSource = provider_BUS.LoadProduct();
            cbbProduct.ValueMember = "id";
            cbbProduct.DisplayMember = "name";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Provider_DTO provider_DTO = new Provider_DTO(0, txtName.Text,txtAddress.Text, txtPhone.Text, int.Parse(cbbProduct.SelectedValue.ToString()));
            if (provider_BUS.New(provider_DTO))
            {
                grvProvider.DataSource = provider_BUS.Load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Provider_DTO provider_DTO = new Provider_DTO(ID, txtName.Text, txtAddress.Text, txtPhone.Text, int.Parse(cbbProduct.SelectedValue.ToString()));
            if (provider_BUS.Edit(provider_DTO))
            {
                grvProvider.DataSource = provider_BUS.Load();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            if (provider_BUS.Delete(ID))
            {
                grvProvider.DataSource = provider_BUS.Load();
            }
        }

        private void grvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grvProvider.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtAddress.Text = row.Cells["addr"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                cbbProduct.SelectedValue = row.Cells["product"].Value;
            }
        }
    }
}
