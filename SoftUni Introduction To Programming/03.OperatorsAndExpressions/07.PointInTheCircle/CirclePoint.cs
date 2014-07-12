using System;

class CirclePoint
{
    static void Main()
    {
        Console.WriteLine("Enter point(x,y) and I'll tell you if the point is in the circle({0,0},2)");
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y=");
        int y = int.Parse(Console.ReadLine());
        if (x*x+y*y<4)
        {
            Console.WriteLine("The point is in the circle");
        }
        else if (x*x+y*y==4)
        {
            Console.WriteLine("The point lies on the border of the circle");
        }
        else
        {
            Console.WriteLine("The point is not in the circle");
        }
        
    }
}

