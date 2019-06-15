using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Provider_DTO
    {
        private int id;
        private string name;
        private string addr;
        private string phone;
        private int product;

        public Provider_DTO(int id, string name, string addr, string phone, int product)
        {
            this.id = id;
            this.name = name;
            this.addr = addr;
            this.phone = phone;
            this.product = product;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Product { get => product; set => product = value; }
    }
}
