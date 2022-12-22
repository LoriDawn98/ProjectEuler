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
    }
}




