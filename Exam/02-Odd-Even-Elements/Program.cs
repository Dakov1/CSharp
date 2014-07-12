using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string allnumbers = Console.ReadLine();
            string[] splittednumbers = allnumbers.Split(' ');

            List<double> numbers = new List<double>();
            List<double> evennumbers = new List<double>();
            List<double> oddnumbers = new List<double>();

            double evensum = 0;
            double evenmin = 0;
            double evenmax = 0;

            double oddsum = 0;
            double oddmin = 0;
            double oddmax = 0;

 

            for (int i = 0; i < splittednumbers.Length; i++)
            {
                numbers.Add(double.Parse(splittednumbers[i]));
                
            }

            for (int i = 0; i <= numbers.Count - 1; i++)
            {
                if (i % 2 == 1)
                {
                    evensum = evensum + numbers[i];
                    evennumbers.Add(numbers[i]);
                }
                else
                {
                    oddsum = oddsum + numbers[i];
                    oddnumbers.Add(numbers[i]);
                }
              
            }


            if (evennumbers.Count != 0)
            {
                evenmin = evennumbers.Min();
                evenmax = evennumbers.Max();
            }
            if (oddnumbers.Count != 0)
            {
                oddmin = oddnumbers.Min();
                oddmax = oddnumbers.Max();
            }
            evensum = Math.Round(evensum, 2);
            evenmin = Math.Round(evenmin, 2);
            evenmax = Math.Round(evenmax, 2);
            oddsum = Math.Round(oddsum, 2);
            oddmin = Math.Round(oddmin, 2);
            oddmax = Math.Round(oddmax, 2);
          

            if (oddnumbers.Count != 0 && evennumbers.Count != 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddsum, oddmin, oddmax, evensum, evenmin, evenmax);
            }
            else if (oddnumbers.Count == 0)
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddsum, oddmin, oddmax, evensum, evenmin, evenmax);
            }
            else if (evennumbers.Count == 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", oddsum, oddmin, oddmax, evensum, evenmin, evenmax);
            }
            else if(evennumbers.Count == 0 && oddnumbers.Count == 0)
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }

        }
    }
}
