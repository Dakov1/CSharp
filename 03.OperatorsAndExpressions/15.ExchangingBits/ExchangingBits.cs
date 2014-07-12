using System;

class ExchangingBits
{
    static void Main()
    {
        Console.WriteLine("Write an integer");
        int num = int.Parse(Console.ReadLine());
        //get value of 24th,25th,26th bits
        int bit242526 = num & (7 << 24);
        //get value of 3th,4th,5th bits
        int bit345 = num & (7 << 3);
        //zeroing 3,4,5,24,25,26 th bits
        num = num & (~(1 << 3));
        num = num & (~(1 << 4));
        num = num & (~(1 << 5));
        num = num & (~(1 << 24));
        num = num & (~(1 << 25));
        num = num & (~(1 << 26));
        // put 24,25,26 bits of position 3,4,5
        bit242526 = bit242526 >> 21;
        // put 3,4,5 bits of position 24,25,26
        bit345 = bit345 << 21;
        //put value of 3,4,5 bits to places of 24,25,26 and value of 24,25,26 to places of 3,4,5
        int finalNum = num | bit242526 | bit345;
        //printing result
        Console.WriteLine(finalNum);
    }
}

