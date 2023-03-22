using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class GetWage
    {
        public static void DailyWage()
        {
            int WAGE_PER_HOUR = 20;
            int HOUR_PER_DAY = 8;
            int EmpWage = (WAGE_PER_HOUR * HOUR_PER_DAY);
            Console.WriteLine("Employee wage per day is "+EmpWage);
        }
    }
}
