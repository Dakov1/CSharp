using System;

class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how much number we will sum");
        int count = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter Number:");
            int number = int.Parse(Console.ReadLine());
            sum += number;

        }
        Console.WriteLine(sum);
    }
}

