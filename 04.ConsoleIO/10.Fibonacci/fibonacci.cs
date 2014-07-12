using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter a number and I'll print first n number of fibonacci sequence");
        int number = int.Parse(Console.ReadLine());
       
        
        if (number==1)
        {
            Console.WriteLine(0);
        }
        else if (number==1)
        {
            Console.WriteLine("0,1");
        }
        else if (number == 3)
        {
            Console.WriteLine("0,1,1");
        }
        else
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
}

