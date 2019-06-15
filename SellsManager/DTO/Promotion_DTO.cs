using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Promotion_DTO
    {
        private int id;
        private string name;
        private string dateStart;
        private string dateEnd;
        private int product;
        private int endow;
        private string description;

        public Promotion_DTO(int id, string name, string dateStart, string dateEnd, int product, int endow, string description)
        {
            this.id = id;
            this.name = name;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.product = product;
            this.endow = endow;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateStart { get => dateStart; set => dateStart = value; }
        public string DateEnd { get => dateEnd; set => dateEnd = value; }
        public int Product { get => product; set => product = value; }
        public int Endow { get => endow; set => endow = value; }
        public string Description { get => description; set => description = value; }
    }
}
