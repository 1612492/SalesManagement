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
    public class Provider_BUS
    {
        Provider_DAL proDAL = new Provider_DAL();

        public DataTable Load()
        {
            return proDAL.Load();
        }

        public bool Edit(Provider_DTO proDTO)
        {
            return proDAL.Edit(proDTO);
        }

        public bool Delete(int id)
        {
            return proDAL.Delete(id);
        }
    }
}
