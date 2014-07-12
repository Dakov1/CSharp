using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Enter Number Between 0 and 999");
        int number;
        while (!int.TryParse(Console.ReadLine(),out number)||number<0||number>999)
        {
            Console.WriteLine("Invalid Input");
        }
        int firstDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number / 100;
        if (number ==0)
        {
            Console.WriteLine("zero");
        }
        else if (firstDigit==0&&secondDigit==0)
        {
            switch (thirdDigit)
            {
                case 1:
                    Console.WriteLine("One hundred");
                    break;
                case 2:
                    Console.WriteLine("Two hundred");
                    break;
                case 3:
                    Console.WriteLine("Three hundred");
                    break;
                case 4:
                    Console.WriteLine("Four hundred");
                    break;
                case 5:
                    Console.WriteLine("Five hundred");
                    break;
                case 6:
                    Console.WriteLine("Six hundred");
                    break;
                case 7:
                    Console.WriteLine("Seven hundred");
                    break;
                case 8:
                    Console.WriteLine("Eight hundred");
                    break;
                case 9:
                    Console.WriteLine("Nine hundred");
                    break;
            }

        }
        else
        {
            string firstDigitStr=string.Empty;
            string secondDigitStr = string.Empty;
            string thirdDigitStr = string.Empty;
            if (secondDigit != 1)
            {
                switch (firstDigit)
                {
                    case 1:
                        firstDigitStr = "one";
                        break;
                    case 2:
                        firstDigitStr = "two";
                        break;
                    case 3:
                        firstDigitStr = "three";
                        break;
                    case 4:
                        firstDigitStr = "four";
                        break;
                    case 5:
                        firstDigitStr = "five";
                        break;
                    case 6:
                        firstDigitStr = "six";
                        break;
                    case 7:
                        firstDigitStr = "seven";
                        break;
                    case 8:
                        firstDigitStr = "eight";
                        break;
                    case 9:
                        firstDigitStr = "nine";
                        break;
                }
            }
            switch (secondDigit)
            {
               case 1:
                    switch (firstDigit)
	                {
		                case 1:
                            secondDigitStr ="eleven";
                            break;
                        case 2:
                            secondDigitStr ="twelve";
                            break;
                        case 3:
                            secondDigitStr = "thirteen";
                            break;
                        case 4:
                            secondDigitStr = "fourteen";
                            break;
                        case 5:
                            secondDigitStr = "fifteen";
                            break;
                        case 6:
                            secondDigitStr = "sixteen";
                            break;
                        case 7:
                            secondDigitStr = "seventeen";
                            break;
                        case 8:
                            secondDigitStr = "eighteen";
                            break;
                        case 9:
                            secondDigitStr = "nineteen";
                            break;


	                }
                    break;
                case 2:
                    secondDigitStr = "twenty ";
                    break;
                case 3:
                    secondDigitStr = "thirty ";
                    break;
                case 4:
                    secondDigitStr = "fourty ";
                    break;
                case 5:
                    secondDigitStr = "fifty ";
                    break;
                case 6:
                    secondDigitStr = "sixty ";
                    break;
                case 7:
                    secondDigitStr = "seventy ";
                    break;
                case 8:
                    secondDigitStr = "eighty ";
                    break;
                case 9:
                    secondDigitStr = "ninety ";
                    break;
            }
            switch (thirdDigit)
            {
                case 1:
                    thirdDigitStr="One hundred and ";
                    break;
                case 2:
                    thirdDigitStr="Two hundred and ";
                    break;
                case 3:
                    thirdDigitStr="Three hundred and ";
                    break;
                case 4:
                    thirdDigitStr="Four hundred and ";
                    break;
                case 5:
                    thirdDigitStr="Five hundred and ";
                    break;
                case 6:
                    thirdDigitStr="Six hundred and ";
                    break;
                case 7:
                    thirdDigitStr="Seven hundred and ";
                    break;
                case 8:
                    thirdDigitStr="Eight hundred and ";
                    break;
                case 9:
                    thirdDigitStr = "Nine hundred and ";
                    break;
            }
            Console.WriteLine("{0}{1}{2}", thirdDigitStr, secondDigitStr, firstDigitStr);
        }
    }
}

