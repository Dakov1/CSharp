using System;

class BiggestNumber
{
    static void Main()
    {
        float num = float.Parse(Console.ReadLine());
        float numtwo = float.Parse(Console.ReadLine());
        float numthree = float.Parse(Console.ReadLine());

        if (num>numtwo&&num>numthree)
        {
            Console.WriteLine(num);
        }
        else if (numtwo>num&&numtwo>numthree)
        {
            Console.WriteLine(numtwo);
        }
        else
        {
            Console.WriteLine(numthree);
        }
    }
}

