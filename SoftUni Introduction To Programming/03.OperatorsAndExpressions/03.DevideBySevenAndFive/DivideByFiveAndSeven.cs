using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer and I'll tell you could it devided by 7 and 5");
        int number = int.Parse(Console.ReadLine());

        if (number%35==0)
        {
            Console.WriteLine("Your number can be divided to 7 and 5");
        }
        else
        {
            Console.WriteLine("Your number can't be divided to 7 and 5");
        }
    }
}

