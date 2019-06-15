using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Customer_DTO
    {
        private int id;
        private string name;
        private string gender;
        private string birthday;
        private string addr;
        private string cardId;
        private int point;

        public Customer_DTO(int id, string name, string gender, string birthday, string addr, string cardId, int point)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.addr = addr;
            this.cardId = cardId;
            this.point = point;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Addr { get => addr; set => addr = value; }
        public string CardId { get => cardId; set => cardId = value; }
        public int Point { get => point; set => point = value; }
    }
}
