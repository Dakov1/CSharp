using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        float sum = a + b + c;
        Console.WriteLine(sum);

    }
}

