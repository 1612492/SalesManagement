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
    public class Sale_BUS
    {
        Sale_DAL salDAL = new Sale_DAL();
        public DataTable LoadCategory()
        {
            return salDAL.LoadCategory();
        }

        public DataTable LoadProduct(int id)
        {
            return salDAL.LoadProduct(id);
        }

        public int NewBill(Bill_DTO bill)
        {
            return salDAL.NewBill(bill);
        }

        public bool addItem(int idPro, int idBill)
        {
            return salDAL.addItem(idPro, idBill);
        }
    }
}
