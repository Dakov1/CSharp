//Problem 3. Comparing Floats
//Write a program that safely compares floating-point numbers with 
//precision eps = 0.000001. Note that we cannot directly compare two 
//floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than 
//a fixed constant eps. Examples:


using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("The program will compare two floats with precision 0.000001");
        // Get first float
        Console.WriteLine("Enter first float a=");
        float a = float.Parse(Console.ReadLine());
        // Get Second Float
        Console.WriteLine("Enter second float b=");
        float b = float.Parse(Console.ReadLine());
        if ((a - b) <= 0.000001 && (a - b) >= -0.000001)
        {
            Console.WriteLine("Floats are approximately equal");
        }
        else
        {
            Console.WriteLine("Floats are not approximately equal");
        }
    }
}

