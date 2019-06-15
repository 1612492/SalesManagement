using SellsManager.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.BUS
{
    public class Bill_BUS
    {
        Bill_DAL bill_DAL = new Bill_DAL();
        public DataTable Load()
        {
            return bill_DAL.Load();
        }

        public DataTable LoadPro(int id)
        {
            return bill_DAL.LoadPro(id);
        }
    }
}
