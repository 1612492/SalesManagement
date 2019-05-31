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
    public class Customer_DAL : DB_Connect
    {
        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool New(Customer_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Customer(name, gender, birthday, addr, cardId) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    pro.Name, pro.Gender, pro.Birthday, pro.Addr, pro.CardId);
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

        public bool Edit(Customer_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Customer SET name = '{0}', gender = '{1}', birthday = '{2}', addr = '{3}', cardId = '{4}' WHERE id = {5}",
                    pro.Name, pro.Gender, pro.Birthday, pro.Addr, pro.CardId, pro.Id);
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
                string query = string.Format("DELETE FROM Customer WHERE id = {0})", id);
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
