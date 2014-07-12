using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 9");
        int a = int.Parse(Console.ReadLine());
        while (a<1||a>9)
        {
            Console.WriteLine("Invalid Numbers");
            a = int.Parse(Console.ReadLine());
        }
        if (a<=3)
        {
            a *= 10;
            Console.WriteLine("{0}", a *10);
        }
        else if (a<=6)
        {
            Console.WriteLine("{0}", a * 100);
        }
        else
        {
            Console.WriteLine("{0}", a * 1000);
        }
    }
}

