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
    public class Product_DAL : DB_Connect
    {
        public DataTable LoadCategory()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool New(Product_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Product(name, category, importPrice, exportPrice, number) VALUES (N'{0}', {1}, {2}, {3}, {4})",
                    pro.Name, pro.Category, pro.ImportPrice, pro.ExportPrice, pro.Number);
                SqlCommand cmd = new SqlCommand(query, con);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Add(Product_DTO pro, int num)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Product SET number = {0} WHERE id = {1}",
                    pro.Number + num, pro.Id);
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

        public bool Edit(Product_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Product SET name = N'{0}', category = {1}, importPrice = {2}, exportPrice = {3}, number = {4} WHERE id = {5}",
                    pro.Name, pro.Category, pro.ImportPrice, pro.ExportPrice, pro.Number,pro.Id);
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
