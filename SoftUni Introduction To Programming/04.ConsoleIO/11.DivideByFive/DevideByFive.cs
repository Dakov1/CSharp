using System;

class DevideByFive
{
    static void Main()
    {
        Console.WriteLine("Enter Two positive numbers");
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i =a;i <=b; i++)
        {
            if (i%5==0)
            {
                Console.Write("{0}, ",i);
                count++;

            }
        }
        Console.WriteLine("There is {0} numbers between {1} and {2} that the reminder of the division by 5 is 0",count , a, b);

    }
}

