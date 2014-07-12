using System;

class DechOfCards
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            switch (i)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    for (int j = 3; j < 7; j++)
                    {
                        Console.Write("{0}{1}", i, (char)j);
                    }
                    break;
                case 11:
                    for (int j = 3; j < 7; j++)
                    {
                        Console.Write("{0}{1}", "J", (char)j);
                    }
                    break;
                case 12:
                    for (int j = 3; j < 7; j++)
                    {
                        Console.Write("{0}{1}", "Q", (char)j);
                    }
                    break;
                case 13:
                    for (int j = 3; j < 7; j++)
                    {
                        Console.Write("{0}{1}", "K", (char)j);
                    }
                    break;
                case 14:
                    for (int j = 3; j < 7; j++)
                    {
                        Console.Write("{0}{1}", "A", (char)j);
                    }
                    break;
            }
            Console.WriteLine();
         }
    }
}

