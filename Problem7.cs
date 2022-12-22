using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem7
    {
        public long getPrimeNum(long numToGet)
        {
            int primeCount = 0;
            long currentNum = 2;
            while(primeCount < numToGet)
            {
                if(isPrime(currentNum))
                    primeCount++;
                currentNum++;
            }
            return currentNum - 1;
        }
        static bool isPrime(long num)
        {
            if (num == 2)
                return true;

            if (num < 2 || num % 2 == 0)
                return false;

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
