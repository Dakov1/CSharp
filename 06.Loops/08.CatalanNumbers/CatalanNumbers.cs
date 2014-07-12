using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (1 < n&&n < 100)
        {
            BigInteger numerator = 1;
            BigInteger denomenator = 1;
            BigInteger result = 1;
            for (int k = 2; k <= n; k++)
            {
                numerator *= n + k;
                denomenator *= k;
            }
            result = numerator / denomenator;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

