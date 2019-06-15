using SellsManager.BUS;
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
    public partial class FindMember : Form
    {
        Customer_BUS customer_BUS = new Customer_BUS();
        public static bool isMember;
        public FindMember()
        {
            InitializeComponent();
        }

        private void txtMember_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grvMember.DataSource;
            bs.Filter = "name like '%" + txtMember.Text + "%'";
            grvMember.DataSource = bs;
        }

        private void FindMember_Load(object sender, EventArgs e)
        {
            grvMember.DataSource = customer_BUS.Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            isMember = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isMember = false;
            this.Close();
        }
    }
}
