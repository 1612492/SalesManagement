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
    public partial class Products : UserControl
    {
        Product_BUS product_BUS = new Product_BUS();
        public static string id;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            grvProduct.DataSource = product_BUS.Load();
            cbbCat.DataSource = product_BUS.LoadCategory();
            cbbCat.ValueMember = "id";
            cbbCat.DisplayMember = "name";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Product_DTO product_DTO = new Product_DTO(0, txtName.Text, int.Parse(cbbCat.SelectedValue.ToString()), int.Parse(txtImPrice.Text), int.Parse(txtExPirce.Text), int.Parse(txtNumber.Text));
            if (product_BUS.New(product_DTO))
            {
                grvProduct.DataSource = product_BUS.Load();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Product_DTO product_DTO = new Product_DTO(ID, txtName.Text, int.Parse(cbbCat.SelectedValue.ToString()), int.Parse(txtImPrice.Text), int.Parse(txtExPirce.Text), int.Parse(txtNumber.Text));
            if (product_BUS.Add(product_DTO, int.Parse(txtNumAdd.Text)))
            {
                grvProduct.DataSource = product_BUS.Load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Product_DTO product_DTO = new Product_DTO(ID, txtName.Text, int.Parse(cbbCat.SelectedValue.ToString()), int.Parse(txtImPrice.Text), int.Parse(txtExPirce.Text), int.Parse(txtNumber.Text));
            if (product_BUS.Edit(product_DTO))
            {
                grvProduct.DataSource = product_BUS.Load();
            }
        }

        private void grvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grvProduct.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                cbbCat.SelectedValue = row.Cells["category"].Value;
                txtImPrice.Text = row.Cells["importPrice"].Value.ToString();
                txtExPirce.Text = row.Cells["exportPrice"].Value.ToString();
                txtNumber.Text = row.Cells["number"].Value.ToString();
                txtNumAdd.Text = "";
            }
        }
    }
}
