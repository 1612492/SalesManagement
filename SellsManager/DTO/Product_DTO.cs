using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Product_DTO
    {
        private int id;
        private string name;
        private int category;
        private int importPrice;
        private int exportPrice;
        private int number;

        public Product_DTO(int id, string name, int category, int importPrice, int exportPrice, int number)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.importPrice = importPrice;
            this.exportPrice = exportPrice;
            this.number = number;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Category { get => category; set => category = value; }
        public int ImportPrice { get => importPrice; set => importPrice = value; }
        public int ExportPrice { get => exportPrice; set => exportPrice = value; }
        public int Number { get => number; set => number = value; }
    }
}
