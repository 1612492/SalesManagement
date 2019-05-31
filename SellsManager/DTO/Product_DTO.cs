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
        private string category;
        private string importPrice;
        private string exportPrice;
        private int number;
        private int provider;

        public Product_DTO(int id, string name, string category, string importPrice, string exportPrice, int number, int provider)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.importPrice = importPrice;
            this.exportPrice = exportPrice;
            this.number = number;
            this.provider = provider;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string ImportPrice { get => importPrice; set => importPrice = value; }
        public string ExportPrice { get => exportPrice; set => exportPrice = value; }
        public int Number { get => number; set => number = value; }
        public int Provider { get => provider; set => provider = value; }
    }
}
