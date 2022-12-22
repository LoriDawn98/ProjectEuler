// See https://aka.ms/new-console-template for more information
using Project_Euler;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        //Euler Problem 1
        Problem1 problem1 = new Problem1();
        List<int> multiplesOf3and5 = problem1.getMultiplesOfTwoNumbers(3, 5, 1000);
        int sum = 0;
        sum = multiplesOf3and5.Sum();
        Console.WriteLine(sum);
        Console.WriteLine(String.Join(", ", multiplesOf3and5));
       // multiplesOf3and5.ForEach(Console.WriteLine);


    }
}




