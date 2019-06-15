using SellsManager.DAL;
using SellsManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.BUS
{
    public class Customer_BUS
    {
        Customer_DAL cusDAL = new Customer_DAL();

        public DataTable Load()
        {
            return cusDAL.Load();
        }

        public bool New(Customer_DTO proDTO)
        {
            return cusDAL.New(proDTO);
        }

        public bool Edit(Customer_DTO proDTO)
        {
            return cusDAL.Edit(proDTO);
        }

        public bool Delete(int id)
        {
            return cusDAL.Delete(id);
        }
    }
}
