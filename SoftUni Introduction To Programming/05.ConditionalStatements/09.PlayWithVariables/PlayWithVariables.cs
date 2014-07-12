using System;

class PlayWithVariables
{
    static void Main()
    {
        while (true)
        {


            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string type = Console.ReadLine();
            if (type == "1")
            {
                Console.Write("Please Enter a Integer:");
                int num = int.Parse(Console.ReadLine());
                num++;
                Console.WriteLine(num);
                break;
            }
            else if (type == "2")
            {
                Console.Write("Please Enter a Double:");
                double num = double.Parse(Console.ReadLine());
                num++;
                Console.WriteLine(num);
                break;
            }
            else if (type == "3")
            {
                Console.Write("Please Enter a String:");
                string str = Console.ReadLine();
                str = str + "*";
                Console.WriteLine(str);
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}

