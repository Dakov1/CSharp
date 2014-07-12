using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Put an integer between 1 and 100");
        int n = int.Parse(Console.ReadLine());
        if (n==1||n==0)
        {
           Console.WriteLine("This integer is simple");
           return;
        }
        int i;
        for (i = 2; n % i != 0; i++)
        {


        }
        if (n == i)
        {
            Console.WriteLine("This integer is simple");
        }
        else
        {
            Console.WriteLine("This integer is not simple");
        }
    }
}

