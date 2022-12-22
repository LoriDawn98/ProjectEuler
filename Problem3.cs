using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem3
    {
        public long getLargestPrimeFactor(long num)
        {
            long largestPrimeFactor = 1;

            while (num % 2 == 0)
            {
                largestPrimeFactor = 2;
                num /= 2;
            }
            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    largestPrimeFactor = i;
                    num /= i;
                }
            }
            if (num > 2)
            {
                largestPrimeFactor = num;
            }
            return largestPrimeFactor;
        }
    }
}
