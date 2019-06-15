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
    public class Provider_DAL : DB_Connect
    {
        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Provider", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable LoadProduct()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool New(Provider_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Provider(name, addr, phone, product) VALUES (N'{0}', N'{1}', '{2}', {3})",
                    pro.Name, pro.Addr, pro.Phone, pro.Product);
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

        public bool Edit(Provider_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Provider SET name = N'{0}', addr = N'{1}', phone = '{2}', product = {3} WHERE id = {4}",
                    pro.Name, pro.Addr, pro.Phone, pro.Product, pro.Id);
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

        public bool Delete(int id)
        {
            try
            {
                con.Open();
                string query = string.Format("DELETE FROM Provider WHERE id = {0}", id);
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
