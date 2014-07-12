using System;

class Gravity
{
    static void Main()
    {
        Console.Write("Please enter your weight:");
        float weight = float.Parse(Console.ReadLine());

        float moonWeight = weight * 0.17f;
        Console.WriteLine("Your weight on the moon it will be:{0}kg",moonWeight);
    }
}

