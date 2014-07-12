using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Exam_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string partofday = Console.ReadLine();


            int ehours = int.Parse(Console.ReadLine());
            int eminutes = int.Parse(Console.ReadLine());


            DateTime thetime = new DateTime();
            thetime = DateTime.Parse(hour + ":" + minutes + " " + partofday);


            DateTime endofexam = thetime.AddHours(ehours).AddMinutes(eminutes);

            string result = endofexam.ToString("hh:mm:tt");

            Console.WriteLine(result);
        }
    }
}
