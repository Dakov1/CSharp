using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal sum=1;
        int factorial = 1;
        decimal power=1;
        
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum = sum + (factorial / power); 
        }

        Console.WriteLine("{0:F5}",sum);
       
    }
}

