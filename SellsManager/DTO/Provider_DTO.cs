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

        public Provider_DTO(int id, string name, string addr, string phone)
        {
            this.id = id;
            this.name = name;
            this.addr = addr;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
