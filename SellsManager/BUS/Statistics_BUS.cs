using SellsManager.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellsManager.BUS
{
    public class Statistics_BUS
    {
        Statistics_DAL statistics_DAL = new Statistics_DAL();
        public DataTable Load(string date1, string date2)
        {
            return statistics_DAL.Load(date1, date2);
        }
    }
}
