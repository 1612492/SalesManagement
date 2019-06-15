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
    public partial class Statistics : UserControl
    {
        Statistics_BUS statistics_BUS = new Statistics_BUS();
        public Statistics()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            grvStatistics.DataSource = statistics_BUS.Load(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
        }
    }
}
