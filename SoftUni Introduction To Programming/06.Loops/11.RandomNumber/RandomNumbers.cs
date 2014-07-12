using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("max=");
        int max = int.Parse(Console.ReadLine());
        Console.Write("min=");
        int min = int.Parse(Console.ReadLine());
        Random rdm = new Random();
        for (int i = 0; i < n; i++)
        {
            
            int random = rdm.Next(min, max);
            Console.Write(" {0}",random);
        }
    }
}

