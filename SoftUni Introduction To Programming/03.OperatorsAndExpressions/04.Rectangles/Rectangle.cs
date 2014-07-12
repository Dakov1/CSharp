using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Write Width and Height of a Rectangle and I'll tell you his area and perimeter");
        Console.Write("Enter height:");
        float height = float.Parse(Console.ReadLine());
        Console.Write("Enter width:");
        float width = float.Parse(Console.ReadLine());

        float perimeter = (height + width) * 2;
        float area = height * width;

        Console.WriteLine("The area is:{0}\nThe perimeter is:{1}",area, perimeter);


        

    }
}

