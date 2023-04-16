using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class EqualOrNot
    {
        static void idstrt(double a1, double b1,
                    double c1, double a2,
                    double b2, double c2)
        {
            if ((a1 / a2 == b1 / b2)
                && (a1 / a2 == c1 / c2)
                && (b1 / b2 == c1 / c2))
                Console.WriteLine("The given straight"
                + " lines are identical");

            else
                Console.WriteLine("The given straight"
                    + " lines are not identical");
        }

        
        public static void Main(String[] args)
        {
            double a1 = -2, b1 = 4,
                    c1 = 3, a2 = -6,
                    b2 = 12, c2 = 9;
            idstrt(a1, b1, c1, a2, b2, c2);
        }
    }
}

