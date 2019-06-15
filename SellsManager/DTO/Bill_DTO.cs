using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Bill_DTO
    {
        private int id;
        private string billDate;
        private int allCost;

        public Bill_DTO(int id, string billDate, int allCost)
        {
            this.Id = id;
            this.BillDate = billDate;
            this.AllCost = allCost;
        }

        public int Id { get => id; set => id = value; }
        public string BillDate { get => billDate; set => billDate = value; }
        public int AllCost { get => allCost; set => allCost = value; }
    }
}
