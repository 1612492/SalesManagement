using SellsManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DAL
{
    public class Login_DAL : DB_Connect
    {
        public string getPosition(Login_DTO log)
        {
            string query = String.Format("SELECT position FROM Account Where username = '{0}' and pass = '{1}'", log.Username, log.Password);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["position"].ToString();
            }
            else
                return "";
        }
    }
}
