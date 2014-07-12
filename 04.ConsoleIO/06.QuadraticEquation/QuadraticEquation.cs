using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a,b and c and I'll tell you x1 and x2 if are real");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(b * b - 4 * a * c);
        if (d%1!=0)
        {
            Console.WriteLine("No real roots");
        }
        else
        {
            double firstx =(-b+d)/(2*a);
            double secondx = (-b - d) / (2 * a);

            Console.WriteLine("x1={0}\nx2={1}",firstx, secondx);
        }

    }
}

