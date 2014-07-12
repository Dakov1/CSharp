using System;

class FormatingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter one integer and two floating point numbers");
        Console.Write("Int =");
        int firstNumber;
        //chech if first number is valid
        while (!int.TryParse(Console.ReadLine(),out firstNumber)||firstNumber<0||firstNumber>500)
        {
            Console.Write("Invalid Number\nInt =");
        }
        Console.Write("First double=");
        double secondNumber;
        //chech if second number is valid
        while (!double.TryParse(Console.ReadLine(),out secondNumber))
        {
            Console.WriteLine("Invalid Number");
        }
        Console.Write("Second float=");
        double thirdNumber;
        //chech if third number is valid
        while (!double.TryParse(Console.ReadLine(),out thirdNumber))
        {
            Console.WriteLine("Invalid Number");
        }
        Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);

       
        


    }
}

