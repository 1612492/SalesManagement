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
    public class Category_DAL : DB_Connect
    {
        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool New(Category_DTO cat)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Category(name) VALUES (N'{0}')", cat.Name);
                SqlCommand cmd = new SqlCommand(query, con);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Edit(Category_DTO cat)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Category SET name = N'{0}' WHERE id = {1}",
                    cat.Name, cat.Id);
                SqlCommand cmd = new SqlCommand(query, con);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return false;
        }
    }
}
