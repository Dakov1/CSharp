using System;

class GreatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 2 number and I'll tell you which is greater");
        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        int b = int.Parse(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }

    }
}

