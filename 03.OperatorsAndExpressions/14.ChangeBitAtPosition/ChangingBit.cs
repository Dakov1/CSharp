using System;

class ChangingBit
{
    static void Main()
    {        
            Console.WriteLine("Put a number n, position p and value of bit p (0 or 1) ");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("value=");
            int v = int.Parse(Console.ReadLine());
            //This is the value of the bit (if is 1) in position p represent in decimal
            int valueOfBit = (int)Math.Pow(2, p);

            int mask = 1 << p;
            //if the value of the bit of our number is 0 and v = 0 
            //OR
            //The value of the bit of our number is 1 and v=1
            //Then we don't need to change anything
            if ((((mask & n) == 0)&& v==0)||((mask & n) != 0)&& v==1)
            {
                Console.WriteLine("The {0} bit of number {1} is {2}, so the result is {1}",p, n, v);
                return;
            }
            //If the value of the bit in position p = 0 AND v = 1
            if (((mask & n) == 0) && v == 1)
            {
                //Change the 0 with 1 as add valueOfBit
                n = n + valueOfBit;
                Console.WriteLine(n);

            }
            //The last possibility is when bit of position p is 1 and v = 0
            else
            {
                //Here zeroing the bit as deduct valueOfBit
                n = n - valueOfBit;
                Console.WriteLine(n);
            }
    
    }
}


