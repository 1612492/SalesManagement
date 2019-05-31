using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DAL
{
    public class DB_Connect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DK32S4J\SQLEXPRESS;Initial Catalog=CMart;Integrated Security=True");
    }
}
