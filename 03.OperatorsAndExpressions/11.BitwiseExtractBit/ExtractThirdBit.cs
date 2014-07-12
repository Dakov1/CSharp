using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter a positive Integer and I'll tell you if third bit is 0 or 1");
        uint number = uint.Parse(Console.ReadLine());
        number = number >> 3;
        uint thirdBit = number & 1;
        Console.WriteLine(thirdBit);

    }
}

