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
    public class Sale_DAL : DB_Connect
    {
        public DataTable LoadCategory()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable LoadProduct(int id)
        {
            string query = string.Format("SELECT prod.id as Id, prod.name as Name, prod.exportPrice as Cost, tb.endow as Endow FROM Product as prod left join (SELECT prod.id, prod.name, exportPrice as Cost, prom.endow FROM Product as prod join Promotion as prom on prod.id = prom.product)tb on prod.id = tb.id Where prod.category =  {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public int NewBill(Bill_DTO bill)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Bill(dateBill, price) VALUES (N'{0}', {1})",
                    bill.BillDate, bill.AllCost);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id FROM Bill WHERE id = SCOPE_IDENTITY()", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataRow row = dt.Rows[0];

                return (int)row["id"];

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return 0;
        }

        public bool addItem(int idPro, int idBill)
        {
            try
            {
                con.Open();
                string query = string.Format("INSERT INTO Item(product, bill) VALUES ({0}, {1})",
                    idPro, idBill);
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
