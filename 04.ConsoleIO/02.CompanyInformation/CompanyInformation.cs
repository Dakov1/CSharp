using System;

    class CompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Hello Please enter the following information of your company:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Address:");
            string address = Console.ReadLine();
            Console.Write("Phone number:");
            string phone = Console.ReadLine();
            Console.Write("Fax number:");
            string fax = Console.ReadLine();
            Console.Write("Website:");
            string website = Console.ReadLine();
            Console.Write("Manager:");
            string manager = Console.ReadLine();
            Console.Write("Manager first name:");
            string managerfirstname = Console.ReadLine();
            Console.Write("Manager Last name:");
            string managerlastname = Console.ReadLine();
            Console.Write("Manager age:");
            string mngage = Console.ReadLine();
            Console.Write("Manager phone number:");
            string mngphone = Console.ReadLine();

            Console.WriteLine("Company information:\n");
            Console.WriteLine("\tName:{0}",name);
            Console.WriteLine("\tAddress:{0}",address);
            Console.WriteLine("\tPhone number:{0}",phone);
            Console.WriteLine("\tFax number:{0}", fax);
            Console.WriteLine("\tWebsite:{0}",website);
            Console.WriteLine();
            Console.WriteLine("Manager information:\n");
            Console.WriteLine("\tFirst name:{0}",managerfirstname);
            Console.WriteLine("\tLast name:{0}", managerlastname);
            Console.WriteLine("\tAge:{0}",mngage);
            Console.WriteLine("\tPhone number:{0}",mngphone);


        }
    }

