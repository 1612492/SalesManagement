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
    public partial class Sales : UserControl
    {
        Sale_BUS sale_BUS = new Sale_BUS();
        public static int idRow;
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            cbbCat.DataSource = sale_BUS.LoadCategory();
            cbbCat.ValueMember = "id";
            cbbCat.DisplayMember = "name";
        }

        private void btnSelectCat_Click(object sender, EventArgs e)
        {
            grvProduct.DataSource = sale_BUS.LoadProduct(int.Parse(cbbCat.SelectedValue.ToString()));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grvProduct.Rows[idRow];
                string _id = row.Cells["Id"].Value.ToString();
                string _name = row.Cells["Name"].Value.ToString();
                string _cost = row.Cells["Cost"].Value.ToString();
                string _endow = row.Cells["Endow"].Value.ToString();
                if (!string.IsNullOrEmpty(_id))
                {
                    ListViewItem item = new ListViewItem(new string[] { _id, _name, _cost, _endow });
                    lsvProduct.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Please pick invalid item");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lsvProduct.SelectedItems)
                {
                    lsvProduct.Items.Remove(item);
                }
            }catch
            {

            }
        }

        private void grvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRow = e.RowIndex;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Have a member account?","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FindMember fm = new FindMember();
                fm.ShowDialog();
                var isMember = FindMember.isMember;
                if (isMember)
                {
                    int price = 0;
                    for (var i = 0; i<lsvProduct.Items.Count; i++)
                    {
                        var cost = lsvProduct.Items[i].SubItems[2].Text;
                        var endow = lsvProduct.Items[i].SubItems[3].Text;

                        if (!string.IsNullOrEmpty(endow))
                        {
                            price += int.Parse(cost) * (100 - int.Parse(endow)) / 100;
                        }
                        else
                        {
                            price += int.Parse(cost);
                        }

                        if (price == 0)
                        {
                            MessageBox.Show("No item");
                            return;
                        }

                    }
                    DialogResult res = MessageBox.Show(string.Format("{0:#.000}", Convert.ToDecimal(price.ToString()) / 1000) + " VND", "Total money to paid");
                    if(res == DialogResult.OK)
                    {
                        DateTime datetime = DateTime.Today;
                        Bill_DTO bill_DTO = new Bill_DTO(0, datetime.ToString("yyyy-MM-dd"), price);
                        int idBill = sale_BUS.NewBill(bill_DTO);

                        for (var i = 0; i < lsvProduct.Items.Count; i++)
                        {
                            var _id = lsvProduct.Items[i].SubItems[0].Text;
                            if(!sale_BUS.addItem(int.Parse(_id), idBill))
                            {
                                MessageBox.Show("Error :)");
                            }
                        }
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                int price = 0;

                for (var i = 0; i < lsvProduct.Items.Count; i++)
                {
                    var cost = lsvProduct.Items[i].SubItems[2].Text;
                    price += int.Parse(cost);
                }

                if (price == 0)
                {
                    MessageBox.Show("No item");
                    return;
                }

                DialogResult res = MessageBox.Show(string.Format("{0:#.000}", Convert.ToDecimal(price.ToString()) / 1000) + " VND", "Total money to paid");
                if (res == DialogResult.OK)
                {
                    DateTime datetime = DateTime.Today;
                    Bill_DTO bill_DTO = new Bill_DTO(0, datetime.ToString("yyyy-MM-dd"), price);
                    int idBill = sale_BUS.NewBill(bill_DTO);

                    for (var i = 0; i < lsvProduct.Items.Count; i++)
                    {
                        var _id = lsvProduct.Items[i].SubItems[0].Text;
                        if (!sale_BUS.addItem(int.Parse(_id), idBill))
                        {
                            MessageBox.Show("Error :)");
                        }
                    }
                }
            }
        }
    }
}
