using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DAL
{
    public class Bill_DAL : DB_Connect
    {
        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Bill", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable LoadPro(int id)
        {
            string query = string.Format("SELECT name, exportPrice as Cost FROM Item join Product on product = product.id WHERE bill = {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
