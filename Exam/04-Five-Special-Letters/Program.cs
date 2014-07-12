using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Special_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> list = new List<char>();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e' };
            char a1 = ' ';
            char a2 = ' ';
            char a3 = ' ';
            char a4 = ' ';
            char a5 = ' ';

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());






            for (int first = 0; first < alphabet.Length; first++)
            {

                a1 = alphabet[first];
                
                for (int second = 0; second < alphabet.Length; second++)
                {
                   
                        a2 = alphabet[second];
                    

                    for (int third = 0; third < alphabet.Length; third++)
                    {
                      
                            a3 = alphabet[third];
                        

                        for (int fourth = 0; fourth < alphabet.Length; fourth++)
                        {
                           
                                a4 = alphabet[fourth];
                            

                            for (int fifth = 0; fifth < alphabet.Length; fifth++)
                            {
                           
                                    a5 = alphabet[fifth];
                                    //string untrimmedcombination = string.Concat(a1, a2, a3, a4, a5);
                                    //string combination = untrimmedcombination.Trim(' ');
                                    //Console.WriteLine(combination);
                                

                                if (!string.Concat(a1,a2,a3,a4).Contains(a5))
                                {
                                    if (!string.Concat(a1,a2,a3,a5).Contains(a4))
                                    {
                                        if (!string.Concat(a1,a2,a4,a5).Contains(a3))
                                        {
                                            if (!string.Concat(a1,a3,a4,a5).Contains(a2))
                                            {
                                                if (!string.Concat(a2,a3,a4,a5).Contains(a1))
                                                {
                                                    Console.Write(string.Concat(a1,a2,a3,a4,a5) + " ");
                                                }
                                            }
                                        }
                                    }
                                }
                             
                            }
                        }
                    }
                }

            }
        }
    }
}

   