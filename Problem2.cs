using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem2
    {
        public int getSumOfEvenFibonacci(int range)
        {
            int a = 1, b = 2, c = 0, sum = 0;

            while (b < range)
            {
                if(b%2 == 0)
                {
                    sum += b;
                }

                c = a + b;
                a = b;
                b = c;
            }

            return sum;
        }
    }
}
