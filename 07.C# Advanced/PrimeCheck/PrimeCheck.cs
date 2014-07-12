using System;

class PrimeCheck
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        bool primeCheck = PrimeCheckMethod(n);
        Console.WriteLine("Number - {0} is prime:{1}",n, primeCheck); //print result
    }
    static bool PrimeCheckMethod(int number)
    {
        bool isPrime=true;
        if (number==0) // if num = 0 it's not prime
        {
            isPrime = false;
            return isPrime;
        }
        else if (number == 1)// if num = 1 it's not prime
        {
            isPrime = false;
            return isPrime;
        }
        
        for (int i = 2; i <= Math.Sqrt(number); i++) // else check if num is prime and if is isPrime = false
        {
            if (number%i==0)
            {
                isPrime = false;
                return isPrime;
            }
        }
        
        return isPrime; //return is prime (if it's prime == true, if it's not prime == false)
    }
}

