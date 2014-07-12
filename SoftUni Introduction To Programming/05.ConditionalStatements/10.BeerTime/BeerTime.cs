using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter data in format  hh:mm tt (example 03:00 AM)");
        DateTime time;
        DateTime beerTimeStart = DateTime.Parse("01:00 PM");
        DateTime beerTimeEnd = DateTime.Parse("03:00 AM");
        
        while (!DateTime.TryParse(Console.ReadLine(), out time))
        {
            Console.WriteLine("Invalid Input");
        }
        bool isBeerTime = !(beerTimeEnd<time&&time<beerTimeStart);
        if (isBeerTime)
        {
            Console.WriteLine("It's BEER TIMEEEEEEEEEEEEEEEEEEEEEEE!!!");  
        }
        else
        {
            Console.WriteLine("It's not beer time :("); 
        }
    }
}

