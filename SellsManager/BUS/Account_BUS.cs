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
    public class Account_BUS
    {
        Account_DAL accDAL = new Account_DAL();

        public DataTable Load()
        {
            return accDAL.Load();
        }

        public bool New(Account_DTO proDTO)
        {
            return accDAL.New(proDTO);
        }

        public bool Edit(Account_DTO proDTO)
        {
            return accDAL.Edit(proDTO);
        }

        public bool Delete(int id)
        {
            return accDAL.Delete(id);
        }
    }
}
