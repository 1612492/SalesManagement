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

        public DataTable LoadCategory()
        {
            return proDAL.LoadCategory();
        }

        public DataTable Load()
        {
            return proDAL.Load();
        }

        public bool New(Product_DTO proDTO)
        {
            return proDAL.New(proDTO);
        }

        public bool Add(Product_DTO proDTO, int num)
        {
            return proDAL.Add(proDTO, num);
        }

        public bool Edit(Product_DTO proDTO)
        {
            return proDAL.Edit(proDTO);
        }
    }
}
