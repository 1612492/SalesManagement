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
    public partial class Customers : UserControl
    {
        Customer_BUS customer_BUS = new Customer_BUS();
        public static string id;
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            grvCustomer.DataSource = customer_BUS.Load();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Customer_DTO customer_DTO = new Customer_DTO(0, txtName.Text, cbbGender.SelectedItem.ToString(), dtpBirthday.Value.ToString("yyyy-MM-dd"), txtAddress.Text, txtCardid.Text.Trim(),0);
            if (customer_BUS.New(customer_DTO))
            {
                grvCustomer.DataSource = customer_BUS.Load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Customer_DTO customer_DTO = new Customer_DTO(ID, txtName.Text, cbbGender.SelectedItem.ToString(), dtpBirthday.Value.ToString("yyyy-MM-dd"), txtAddress.Text, txtCardid.Text,0);
            if (customer_BUS.Edit(customer_DTO))
            {
                grvCustomer.DataSource = customer_BUS.Load();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            if (customer_BUS.Delete(ID))
            {
                grvCustomer.DataSource = customer_BUS.Load();
            }
        }

        private void grvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grvCustomer.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                cbbGender.SelectedItem = row.Cells["gender"].Value.ToString();
                dtpBirthday.Value = (DateTime)row.Cells["birthday"].Value;
                txtAddress.Text = row.Cells["addr"].Value.ToString();
                txtCardid.Text = row.Cells["cardId"].Value.ToString();
            }
        }
    }
}
