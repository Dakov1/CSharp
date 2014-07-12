using System;

class DigitAsWord
{
    static void Main()
    {
        int num = 0;

        while (!int.TryParse(Console.ReadLine(), out num) || num > 9 || num < 0)
        {
            Console.WriteLine("Invalid Input");
        }
        switch (num)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
        }
    }
}

