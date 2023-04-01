using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Powerof2
    {
        public static void PowerOfTwo(int num)
        {
            int Power = 1;
            if(num > 31)
            {
                Console.WriteLine("Value must be less than 31");
            }
            else
            {
                for(int i = 0; i < num; i++)
                {
                    Power = Power * 2;
                    Console.WriteLine(Power);
                }
            }
        }
    }
}
