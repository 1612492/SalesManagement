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
    public class Category_BUS
    {
        Category_DAL catDAL = new Category_DAL();

        public DataTable Load()
        {
            return catDAL.Load();
        }

        public bool New(Category_DTO catDTO)
        {
            return catDAL.New(catDTO);
        }

        public bool Edit(Category_DTO catDTO)
        {
            return catDAL.Edit(catDTO);
        }
    }
}
