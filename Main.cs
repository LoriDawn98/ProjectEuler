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
    }
}




