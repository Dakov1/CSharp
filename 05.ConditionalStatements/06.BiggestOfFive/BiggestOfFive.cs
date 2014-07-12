using System;

class BiggestOfFive
{
    static void Main()
    {
        float one = float.Parse(Console.ReadLine());
        float two = float.Parse(Console.ReadLine());
        float three = float.Parse(Console.ReadLine());
        float four = float.Parse(Console.ReadLine());
        float five = float.Parse(Console.ReadLine());
        if (one>two&&one>three&&one>four&&one>five)
        {
            Console.WriteLine(one);
        }
        else if (two>one&&two>three&&two>four&&two>five)
        {
            Console.WriteLine(two);
        }
        else if (three>one&&three>two&&three>four&&three>five)
        {
            Console.WriteLine(three);
        }
        else if (four>one&&four>two&&four>three&&four>five)
        {
            Console.WriteLine(four);
        }
        else
        {
            Console.WriteLine(five);
        }
    }
}

