﻿using System;

class NotDivisible
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            if (i%3!=0 && i%7!=0)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}

