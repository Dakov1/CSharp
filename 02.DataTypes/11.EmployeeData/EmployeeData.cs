//Problem 11. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a 
//single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        sbyte age = 22;
        char geneder = 'f';
        long idNumber = 8306112507;
        int empNumber = 27569999;

        Console.WriteLine("First name:{0}\nLast name:{1}\nAge:{2}\nGender:{3}\nID Number:{4}\nEmployee Number:{5}", firstName, lastName, age, geneder, idNumber, empNumber);
    }
}

