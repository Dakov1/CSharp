using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());


            PrintUpper(width);

        }


        static void PrintUpper(int n)
        {
            Console.Write(new string('.', (n - 1) / 2));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', (n - 1) / 2));
            PrintMiddle(n);
        }



        static void PrintMiddle(int n)
        {

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(new string('.', (n - 1) / 2));
                Console.Write("#");
                Console.Write(new string('.', n - 2));
                Console.Write("#");
                Console.WriteLine(new string('.', (n - 1) / 2));
            }
            PrintCenter(n);
        }


        static void PrintCenter(int n)
        {

            Console.Write(new string('#', (n / 2) + 1));
            Console.Write(new string('.', n - 2));
            Console.WriteLine(new string('#', (n / 2) + 1));
            PrintLower(n);
        }

        static void PrintLower(int n)
        {
            int constant = (n * 2) - 1;
            int c = 0;
            int howmanyi = 4;
            for (int r = 1; r <= n - 1; r++)
            {
                c = constant - howmanyi;
            
                Console.Write(new string('.', r));
                Console.Write("#");
                if (c > 0)
                {
                    Console.Write(new string('.', c));
                    Console.Write("#");
                }

                Console.WriteLine(new string('.', r));

                howmanyi += 2;

            }
        }
    }
}
