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
    public partial class Category : UserControl
    {
        Category_BUS category_BUS = new Category_BUS();
        public static string id;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            grvCategory.DataSource = category_BUS.Load();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Category_DTO category_DTO = new Category_DTO(0, txtName.Text);
            if (category_BUS.New(category_DTO))
            {
                grvCategory.DataSource = category_BUS.Load();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(id);
            Category_DTO category_DTO = new Category_DTO(ID, txtName.Text);
            if (category_BUS.Edit(category_DTO))
            {
                grvCategory.DataSource = category_BUS.Load();
            }
        }

        private void grvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grvCategory.Rows[e.RowIndex];
                id = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
            }
        }
    }
}
