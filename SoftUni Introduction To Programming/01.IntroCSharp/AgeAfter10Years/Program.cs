using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a Date in dd/mm/yyyy format"); 
            string birthDateString = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(birthDateString);
            //Now
            double howOldNowY = ((DateTime.Now.Date - birthDate).TotalDays) / 365 ;
            double howOldNowD = ((DateTime.Now.Date - birthDate).TotalDays);
            double howOldNowH = ((DateTime.Now.Date - birthDate).TotalDays) * 24;
            double howOldNowS = ((DateTime.Now.Date - birthDate).TotalDays) * 24 * 60;
            //After 10 years
            double howOldAfterY = ((DateTime.Now.Date.AddYears(10) - birthDate).TotalDays) / 365 ;
            double howOldAfterD = ((DateTime.Now.Date.AddYears(10) - birthDate).TotalDays);
            double howOldAfterH = ((DateTime.Now.Date.AddYears(10) - birthDate).TotalDays) * 24;
            double howOldAfterS = ((DateTime.Now.Date.AddYears(10) - birthDate).TotalDays) * 24 * 60;


            Console.WriteLine("You are now: {0:0.00} years; {1} days; {2} hours old", howOldNowY, howOldNowD, howOldNowH);

            Console.WriteLine("After 10 years you will be: {0:0.00} years; {1} days; {2} hours old", howOldAfterY, howOldAfterD, howOldAfterH);

        }
    }
}
