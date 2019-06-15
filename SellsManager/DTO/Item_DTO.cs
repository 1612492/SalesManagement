using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Item_DTO
    {
        private int id;
        private int idPro;
        private int idBill;

        public Item_DTO(int id, int idPro, int idBill)
        {
            this.Id = id;
            this.IdPro = idPro;
            this.IdBill = idBill;
        }

        public int Id { get => id; set => id = value; }
        public int IdPro { get => idPro; set => idPro = value; }
        public int IdBill { get => idBill; set => idBill = value; }
    }
}
