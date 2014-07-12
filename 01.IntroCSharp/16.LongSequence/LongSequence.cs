//Problem 16. Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
//You might need to learn how to use loops in C# (search in Internet).

using System;

class LongSequence
{
    static void Main()
    {
        
        for (int i = 2,count=0; count < 1000; count++)
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

