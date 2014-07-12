using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter an Enteger and I'll tell you if third digit is 7!");
        int checkedThirdDigit = int.Parse(Console.ReadLine());
        if ((checkedThirdDigit/100)%10==7)
	    {
		    Console.WriteLine("The third digit of your number is 7");

	    }
        else
	    {
            Console.WriteLine("The third digit of your number is not 7");
	    }

    }
}

