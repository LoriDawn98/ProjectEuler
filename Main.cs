using Project_Euler;
using ProjectEuler;
using System;

class EulerDriver
{
    static void Main()
    {
        //Problem 1
        Console.WriteLine("Solving Problem 1: Multiples of 3 or 5");
        Problem1 problem1 = new Problem1();
        int sum = 0;
        sum = problem1.getSumOfMultiples(3, 5, 1000);
        Console.WriteLine("Answer: {0}", sum);

        //Problem 2
        Console.WriteLine("Solving Problem 2: Even Fibonacci Numbers");
        Problem2 problem2 = new Problem2();
        sum = problem2.getSumOfEvenFibonacci(4000000);
        Console.WriteLine("Answer: {0}", sum);

        //Problem 3
        Console.WriteLine("Solving Problem 3: Largest Prime Factor");
        Problem3 problem3 = new Problem3();
        long largestPrimeFactor = problem3.getLargestPrimeFactor(600851475143);
        Console.WriteLine("Answer: {0}", largestPrimeFactor);

        //Problem 4
        Console.WriteLine("Solving Problem 4: Largest Palindrome Product");
        Problem4 problem4 = new Problem4();
        int largestPalindrome = problem4.largestPalindrome();
        Console.WriteLine("Answer: {0}", largestPalindrome);

        //Problem 5
        Console.WriteLine("Solving Problem 5: Smallest Multiple");
        Problem5 problem5 = new Problem5();
        int smallestMultiple = problem5.smallestEvenlyDivisible(20);
        Console.WriteLine("Answer: {0}", smallestMultiple);

        //Problem 6
        Console.WriteLine("Solving Problem 6: Sum Square Difference");
        Problem6 problem6 = new Problem6();
        int sum_sqaure_diff = problem6.problem6Solution();
        Console.WriteLine("Answer: {0}", sum_sqaure_diff);
    }
}




