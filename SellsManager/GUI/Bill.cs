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

namespace SellsManager.GUI
{   
    public partial class Bill : UserControl
    {
        Bill_BUS bill_BUS = new Bill_BUS();
        public static int id;
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            grvBill.DataSource = bill_BUS.Load();
        }

        private void grvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                try
                {
                    DataGridViewRow row = this.grvBill.Rows[e.RowIndex];
                    id = (int)row.Cells["id"].Value;

                    grvPro.DataSource = bill_BUS.LoadPro(id);
                }
                catch
                {
                }
            }
        }
    }
}
