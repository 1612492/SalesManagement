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

        public bool New(Provider_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Product(name, addr, phone) VALUES ('{0}', '{1}', '{2}')",
                    pro.Name, pro.Addr, pro.Phone);
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
                string query = string.Format("UPDATE Provider SET name = '{0}', addr = '{1}', phone = '{2}' WHERE id = {6}",
                    pro.Name, pro.Addr, pro.Phone, pro.Id);
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
                string query = string.Format("DELETE FROM Provider WHERE id = {0})", id);
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
