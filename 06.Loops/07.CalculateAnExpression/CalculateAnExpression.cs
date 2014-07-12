using System;
using System.Numerics;

class CalculateAnExpression
{
    static void Main()
    {
        Console.WriteLine("Enter 2 integer n and k in interval 1<k<n<100");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int difference = n-k;

        
        BigInteger nFactorial = 1;
        for (int i = n; i > 1; i--)
        {
            nFactorial *= i;
        }
        BigInteger kFactorial = 1;
        for (int i = k; i >1 ; i--)
        {
            kFactorial *= i;
        }
        BigInteger differenceFactorial = 1;
        for (int i = difference; i > 1; i--)
        {
            differenceFactorial *= i;
        }
        BigInteger anExpression = nFactorial / (kFactorial * differenceFactorial);
        Console.WriteLine(anExpression);

        
    }
}

