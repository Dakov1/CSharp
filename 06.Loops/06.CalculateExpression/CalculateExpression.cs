using System;

class CalculateExpression
{
    static void Main()
    {
        Console.WriteLine("Enter 2 integer n and k in interval 1<k<n<100");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        ulong factorial=1;
        for (int i = k+1; i < n+1; i++)
        {
            factorial *= (ulong)i;

        }
        Console.WriteLine(factorial);
    }
}

