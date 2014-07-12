using System;


class AreaAndPerimeter
{
    static void Main()
    {
        Console.Write("Enter r of your circle:");
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI*Math.Pow(r, 2);
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("Area:{0:F2}\nPerimeter:{1:F2}",area,perimeter);

    }
}

