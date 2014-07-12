//Problem 9. Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2,count=0; count < 10; count++)
        {
            Console.WriteLine(i);
            if (i>0)
            {
                i = (i + 1) * -1;   
            }
            else
	        {
                i = (i - 1) * -1;
	        }
            
        }
    }
}

