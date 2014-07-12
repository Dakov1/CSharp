using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Write an Integer and I'll tell you is it Add or Even");
        int addOrEven = int.Parse(Console.ReadLine());
        if (addOrEven%2==0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is Odd");
        }
    }
}

