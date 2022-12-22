using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem5
    {
        public int smallestEvenlyDivisible(int range)
        {
            int num = 0;
            bool isDivisible = false;
            while(!isDivisible)
            {
                num++;
                for(int i=1; i<=range; i++)
                {
                    if(num%i != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                    else
                        isDivisible = true;
                }
            }
            return num;
        }
    }
}
