using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNum
    {
        public static void HarNumber(int Nthnumber)
        {
            float Num = 0;
            for (int i = 1; i <= Nthnumber; i++)
            {
                Num += (float)1 / i;

            }
            Console.WriteLine(Num);
        }
    }
}
