using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem6
    {
        public int problem6Solution()
        {
            int sumOfSqaures = getSumOfSquares(100);
            int squareOfSums = getSquareOfSums(100);
            int solution = getDifference(squareOfSums, sumOfSqaures);
            return solution;
        }
        int getSumOfSquares(int range)
        {
            int sumOfSqaures = 0;
            for(int i=1; i<= range; i++)
            {
                sumOfSqaures += i * i;
            }
            return sumOfSqaures;
        }

        int getSquareOfSums(int range)
        {
            int squareOfSums = 0;
            int sum = 0;
            for(int i=1; i<=range; i++)
            {
                sum += i;
            }
            squareOfSums = sum * sum;
            return squareOfSums;
        }

        int getDifference(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }
    }
}
