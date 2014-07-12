using System;

class BitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter a number and a position and I'll tell you is this bit is 1");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        if (bit==1)
        {
            Console.WriteLine("The bit of position p is 1");
        }
        else
        {
            Console.WriteLine("The bit of position p is not 1");
        }
    }
}

