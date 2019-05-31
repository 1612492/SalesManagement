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
    public class Promotion_DAL : DB_Connect
    {
        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Promotion", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool New(Promotion_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Promotion(name, dateStart, dateEnd, product, endow, description) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    pro.Name, pro.DateStart, pro.DateEnd, pro.Product, pro.Endow, pro.Description);
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

        public bool Edit(Promotion_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Promotion SET name = '{0}', dateStart = '{1}', dateEnd = '{2}', product = '{3}', endow = '{4}', description = '{5}' WHERE id = {6}",
                    pro.Name, pro.DateStart, pro.DateEnd, pro.Product, pro.Endow, pro.Description, pro.Id);
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
                string query = string.Format("DELETE FROM Promotion WHERE id = {0})", id);
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
