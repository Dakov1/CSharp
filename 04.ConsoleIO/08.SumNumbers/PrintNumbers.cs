using System;

class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter integer N and I'll print all numbers from 1 to N in single line");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <=number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

