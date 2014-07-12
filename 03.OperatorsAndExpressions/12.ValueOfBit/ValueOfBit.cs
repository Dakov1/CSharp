using System;

class ValueOfBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number and a position and I'll tell you the value of this bit ");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());             
        int nRightP = n >> p;      
        int bit = nRightP & 1;     
        Console.WriteLine(bit);
    }
}

