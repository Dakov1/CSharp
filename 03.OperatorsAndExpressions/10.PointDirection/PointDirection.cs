using System;

class PointDirection
{
    static void Main()
    {
        Console.WriteLine("Enter point(x,y) and I'll tell you if the point is in the circle({1,1},1.5)");
        Console.Write("x=");
        float x = float.Parse(Console.ReadLine());
        Console.Write("y=");
        float r = 1.5f;
        float y = float.Parse(Console.ReadLine());
        bool isInCircle = ((x-1) * (x-1) + (y-1) * (y-1) <= r*r);
        bool isInRectangle = (x>=-1)&&(x<=5)&&(y>=-1)&&(y<=1);
        if (isInCircle&&(isInRectangle==false))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

