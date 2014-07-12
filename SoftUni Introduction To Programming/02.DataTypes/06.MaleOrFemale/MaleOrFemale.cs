//Problem 6. Boolean Variable
//Declare a Boolean variable called isFemale
//and assign an appropriate value corresponding to your gender. Print it on the console.

using System;

class MaleOrFemale
{
    static void Main()
    {
        Console.WriteLine("Enter your gender! m for male , f for female");
        string maleOrFemale = Console.ReadLine();
        bool isFemale;
        if (maleOrFemale=="m")
        {

            isFemale = false;
        }
        else
        {
            isFemale = true;
        }
        Console.WriteLine("It is {0} that you are female", isFemale);
    }
}

