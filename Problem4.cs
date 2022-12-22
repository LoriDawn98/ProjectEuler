using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Problem4
    {
        public bool isPalindrome(string potential)
        {
            char[] potArray = potential.ToCharArray();
            Array.Reverse(potArray);
            string potReversed = new string(potArray);

            if(potential == potReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int largestPalindrome()
        {
            int num1 = 999, num2 = 999;
            List<int> palindromes = new List<int>();

            while (num1 > 0)
            {
                int product = num1 * num2;
                bool productIsPalindrome = isPalindrome(product.ToString());
                if (productIsPalindrome)
                    palindromes.Add(product);
                if (num2 > 0)
                  num2--;
                else
                {
                  num1--;
                  num2 = 999;
                }
            }
            int largestPalindrome = palindromes.Max(); 
            return largestPalindrome;
        }
    }
}
