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
    public class Promotion_BUS
    {
        Promotion_DAL proDAL = new Promotion_DAL();

        public DataTable Load()
        {
            return proDAL.Load();
        }

        public DataTable LoadProduct()
        {
            return proDAL.LoadProduct();
        }

        public bool New(Promotion_DTO proDTO)
        {
            return proDAL.New(proDTO);
        }

        public bool Edit(Promotion_DTO proDTO)
        {
            return proDAL.Edit(proDTO);
        }

        public bool Delete(int id)
        {
            return proDAL.Delete(id);
        }
    }
}
