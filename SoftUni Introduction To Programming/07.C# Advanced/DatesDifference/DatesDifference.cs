using System;

class DatesDifference
{
    static void Main()
    {
        //get the input
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine((secondDate - firstDate).TotalDays); //subtract firstdate from second dates and convert to days
    }
}

