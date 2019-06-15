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
    public partial class Promotion : UserControl
    {
        Promotion_BUS promotion_BUS = new Promotion_BUS();
        public static string id;

        public Promotion()
        {
            InitializeComponent();

            cbbEndow.DisplayMember = "Text";
            cbbEndow.ValueMember = "Value";
        }

        private void Promotion_Load(object sender, EventArgs e)
        {
            grvPromotion.DataSource = promotion_BUS.Load();
            cbbProduct.DataSource = promotion_BUS.LoadProduct();
            cbbProduct.ValueMember = "id";
            cbbProduct.DisplayMember = "name";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbEndow.SelectedItem.GetType().GetProperty("Value").GetValue(cbbEndow.SelectedItem, null).ToString());
            Promotion_DTO promotion_DTO = new Promotion_DTO(0, txtName.Text, dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"), int.Parse(cbbProduct.SelectedValue.ToString()), int.Parse(cbbEndow.SelectedItem.ToString()), txtDescription.Text);
            if (promotion_BUS.New(promotion_DTO))
            {
                grvPromotion.DataSource = promotion_BUS.Load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Promotion_DTO promotion_DTO = new Promotion_DTO(ID, txtName.Text, dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"), int.Parse(cbbProduct.SelectedValue.ToString()), int.Parse(cbbEndow.SelectedItem.ToString()), txtDescription.Text);
            if (promotion_BUS.Edit(promotion_DTO))
            {
                grvPromotion.DataSource = promotion_BUS.Load();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            if (promotion_BUS.Delete(ID))
            {
                grvPromotion.DataSource = promotion_BUS.Load();
            }
        }

        private void grvPromotion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grvPromotion.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                dtpStart.Value = (DateTime)row.Cells["dateStart"].Value;
                dtpEnd.Value = (DateTime)row.Cells["dateEnd"].Value;
                cbbProduct.SelectedValue = row.Cells["product"].Value;
                cbbEndow.SelectedItem = row.Cells["endow"].Value.ToString();
                txtDescription.Text = row.Cells["dcription"].Value.ToString();
            }
        }
    }
}
