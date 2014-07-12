//Problem 10. Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10 and 
//after that exchange their values. Print the variable values before and after the exchange.

using System;

class ChangingValue
{
    static void Main()
    {
        int value1 = 5;
        int value2 = 10;
        int changing;
        changing = value1;
        value1 = value2;
        value2 = changing;
    }
}

