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
            int sum_of_sqaures = getSumOfSquares(100);
            int square_of_sums = getSquareOfSums(100);
            int solution = getDifference(square_of_sums, sum_of_sqaures);
            return solution;
        }
        int getSumOfSquares(int range)
        {
            int sum_of_squares = 0;
            for(int i=1; i<= range; i++)
            {
                sum_of_squares += i * i;
            }
            return sum_of_squares;
        }

        int getSquareOfSums(int range)
        {
            int square_of_sums = 0;
            int sum = 0;
            for(int i=1; i<=range; i++)
            {
                sum += i;
            }
            square_of_sums = sum * sum;
            return square_of_sums;
        }

        int getDifference(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }
    }
}
