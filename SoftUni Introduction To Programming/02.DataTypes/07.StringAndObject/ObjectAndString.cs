﻿//Problem 7. Strings and Objects
//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first
//two variables (mind adding an interval between). Declare a third string variable and 
//initialize it with the value of the object variable (you should perform type casting).

using System;

class ObjectAndString
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concatenate = hello + " " + world;
        string helloWorld = (string)concatenate;

        Console.WriteLine(helloWorld);

    }
}

