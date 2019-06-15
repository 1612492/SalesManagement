using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DAL
{
    public class Statistics_DAL : DB_Connect
    {
        public DataTable Load(string date1, string date2)
        {
            string query = string.Format("SELECT Product.name, COUNT(product) as count FROM Item, Bill, Product WHERE Item.bill = Bill.id AND Item.product = Product.id AND dateBill >= '{0}' AND dateBill <= '{1}' GROUP BY Product.name ORDER BY count DESC", date1, date2);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
