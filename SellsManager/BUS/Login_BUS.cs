using SellsManager.DAL;
using SellsManager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.BUS
{
    public class Login_BUS
    {
        Login_DAL logDAL = new Login_DAL();

        public string getPosition(Login_DTO logDTO)
        {
            return logDAL.getPosition(logDTO);
        }
    }
}
