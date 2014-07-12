using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter an a, b and h ot the trapezoid");
        Console.Write("a=");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b=");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h=");
        float h = float.Parse(Console.ReadLine());

        float area = ((a + b) / 2) * h;

        Console.WriteLine(area);
    }
}

