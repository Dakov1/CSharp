using System;

class FibonacciNumbers
{
    static void Fibonacci (int number)
    {
        if (number==1)
        {
            Console.WriteLine(0); //if num ==1 print first numbers
        }
        else if (number==2)
        {
            Console.WriteLine("0,1");//if num == 2 print first two numbers
        }
        else if (number == 3)
        {
            Console.WriteLine("0,1,1"); // if num == 3 print first three numbers 
        }
        else // else calculate next numbers and print them
        {
            long first = 1;
            long second = 1;

            Console.Write("0,1,1,");
            for (int i = 0; i < number-3; i++)
            {
                
                long third = first + second;
                first = second;
                second = third;
                
                Console.Write("{0},",third);
            }
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Fibonacci(n); //call the method
    }
}

