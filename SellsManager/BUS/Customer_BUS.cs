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
        Customer_DAL proDAL = new Customer_DAL();

        public DataTable Load()
        {
            return proDAL.Load();
        }

        public bool Edit(Customer_DTO proDTO)
        {
            return proDAL.Edit(proDTO);
        }

        public bool Delete(int id)
        {
            return proDAL.Delete(id);
        }
    }
}
