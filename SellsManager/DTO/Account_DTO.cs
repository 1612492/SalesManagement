using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.DTO
{
    public class Account_DTO
    {
        private int id;
        private string name;
        private string gender;
        private DateTime birthday;
        private string addr;
        private string idCard;
        private string phone;
        private DateTime startWorking;
        private string position;
        private string username;
        private string password;

        public Account_DTO(int id, string name, string gender, DateTime birthday, string addr, string idCard, string phone, DateTime startWorking, string position, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.addr = addr;
            this.idCard = idCard;
            this.phone = phone;
            this.startWorking = startWorking;
            this.position = position;
            this.username = username;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Addr { get => addr; set => addr = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime StartWorking { get => startWorking; set => startWorking = value; }
        public string Position { get => position; set => position = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
