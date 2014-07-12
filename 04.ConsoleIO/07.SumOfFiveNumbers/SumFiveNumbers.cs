using System;

class SumFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a five digits separated by a space:");
        string numbers = Console.ReadLine();
        string[] splitetNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int number1 = int.Parse(splitetNumbers[0]);
        int number2 = int.Parse(splitetNumbers[1]);
        int number3 = int.Parse(splitetNumbers[2]);
        int number4 = int.Parse(splitetNumbers[3]);
        int number5 = int.Parse(splitetNumbers[4]);
        int sum = number1+number2+number3+number4+number5;
        Console.WriteLine(sum);
    }

}

