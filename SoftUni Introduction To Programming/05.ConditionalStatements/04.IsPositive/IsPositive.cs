using System;

class IsPositive
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers");
        float firstNum = float.Parse(Console.ReadLine());
        float secondNum = float.Parse(Console.ReadLine());
        float thirdNum = float.Parse(Console.ReadLine());


        if ((firstNum*secondNum*thirdNum)>0)
        {
            Console.WriteLine("+");
        }
        else if (firstNum==0||secondNum==0||thirdNum==0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

