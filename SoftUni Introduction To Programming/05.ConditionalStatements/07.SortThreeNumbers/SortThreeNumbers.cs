using System;

class SortThreeNumbers
{
    static void Main()
    {
        float one = float.Parse(Console.ReadLine());
        float two = float.Parse(Console.ReadLine());
        float three = float.Parse(Console.ReadLine());
        if (one>two&&one>three)
        {
            Console.Write("{0} ",one);
            if (two>three)
            {
                Console.Write("{0} ", two);
                Console.Write("{0} ", three);
            }
            else
            {
                Console.Write("{0} ", three);
                Console.Write("{0} ", two);
            }
            
        }
        else if (two>one&&two>three)
        {
            Console.Write("{0} ", two);
            if (one > three)
            {
                Console.Write("{0} ", one);
                Console.Write("{0} ", three);
            }
            else
            {
                Console.Write("{0} ", three);
                Console.Write("{0} ", one);
            }
        }
        else
        {
            Console.Write("{0} ", three);
            if (one > two)
            {
                Console.Write("{0} ", one);
                Console.Write("{0} ", two);
            }
            else
            {
                Console.Write("{0} ", two);
                Console.Write("{0} ", one);
            }
        }
    }
}

