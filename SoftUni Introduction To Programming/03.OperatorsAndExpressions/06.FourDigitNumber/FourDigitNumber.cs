using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number:");
        int fourDigitNumber = int.Parse(Console.ReadLine());
        int firstDigit = fourDigitNumber % 10;
        int secondDigit = (fourDigitNumber / 10) % 10;
        int thirdDigit = (fourDigitNumber / 100) % 10;
        int forthDigit = (fourDigitNumber / 1000);

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + forthDigit);
        Console.WriteLine("{0}{1}{2}{3}", forthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}",forthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("{0}{1}{2}{3}",firstDigit, thirdDigit, secondDigit, forthDigit);
        
        

    }
}

