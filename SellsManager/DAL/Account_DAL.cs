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
    public class Account_DAL : DB_Connect
    {
        public DataTable Load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Account", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool New(Account_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Account(name, gender, birthday, addr, idCard, phone, startWorking, position, username, pass) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                    pro.Name, pro.Gender, pro.Birthday, pro.Addr, pro.IdCard, pro.Phone, pro.StartWorking, pro.Position, pro.Username, pro.Password);
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

        public bool Edit(Account_DTO pro)
        {
            try
            {
                con.Open();
                string query = string.Format("UPDATE Account SET name = '{0}', gender = '{1}', birthday = '{2}', addr = '{3}', idCard = '{4}', phone = '{5}', startWorking = '{6}', position = '{7}', username = '{8}', pass = '{9}' WHERE id = {10}",
                    pro.Name, pro.Gender, pro.Birthday, pro.Addr, pro.IdCard, pro.Phone, pro.StartWorking, pro.Position, pro.Username, pro.Password, pro.Id);
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
                string query = string.Format("DELETE FROM Account WHERE id = {0})", id);
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
