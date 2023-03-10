using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem1
    {
        public int getSumOfMultiples(int value1, int value2, int range)
        {
            int sum = 0;
            List<int> multiplesOf3and5 = getMultiplesOfTwoNumbers(value1, value2, range);
            sum = multiplesOf3and5.Sum();
            return sum;
        }

        public List<int> getMultiplesOfTwoNumbers(int value1, int value2, int range)
        {
            List<int> valuesMultiples = new List<int>();
            for(int i=1; i<range; i++)
            {
                if(i%value1 == 0 || i%value2 == 0)
                {
                    valuesMultiples.Add(i);
                }
            }
            return valuesMultiples;
        }
    }
}
