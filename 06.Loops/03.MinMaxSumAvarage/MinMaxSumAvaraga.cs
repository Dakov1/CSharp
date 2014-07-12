using System;

class MinMaxSumAvaraga
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter n numbers each at single line");
        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
            avg = sum / n;
        }
        Console.WriteLine("Min Value={0}",min);
        Console.WriteLine("Max Value={0}",max);
        Console.WriteLine("Sum={0}",sum);
        Console.WriteLine("Avg={0:F2}",avg);
    }
}

