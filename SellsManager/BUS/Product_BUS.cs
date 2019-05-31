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
    public class Product_BUS
    {
        Product_DAL proDAL = new Product_DAL();

        public DataTable Load()
        {
            return proDAL.Load();
        }

        public bool Add(Product_DTO proDTO, int num)
        {
            return proDAL.Add(proDTO, num);
        }

        public bool Edit(Product_DTO proDTO)
        {
            return proDAL.Edit(proDTO);
        }

        public bool Delete(int id)
        {
            return proDAL.Delete(id);
        }
    }
}
