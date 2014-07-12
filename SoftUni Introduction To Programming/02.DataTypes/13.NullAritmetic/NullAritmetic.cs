//Problem 13. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullAritmetic
{
    static void Main()
    {
        int? integer = null;
        double? doubleNum = null;
        Console.WriteLine("The variables with null literals:\nInt:{0}\nDouble:{1}",integer, doubleNum);
        integer++;
        doubleNum++;
        Console.WriteLine("{0}{1}",integer, doubleNum);
        integer = integer + null;
        doubleNum = doubleNum + null;
        Console.WriteLine("{0}{1}", integer, doubleNum);
    }
}

