using System;
using System.Collections.Generic;

class PrimeCheckInInterval
{
    static void Main()
    {
        //get the input
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        List<int> AllPrimeNumbers = CalculatePrimenNumbersInInterval(numOne, numTwo);//call the method that check all numbers in interval
        foreach (var num in AllPrimeNumbers) // making loop that prints all nums from list 
        {
            Console.WriteLine(num);
        }
    }
    static List<int> CalculatePrimenNumbersInInterval(int numOne, int numTwo)
    { 
        List<int> primeNumbers = new List<int>(); // declare a list that we will save all prime numbers 
        bool isPrime = true;//declare a bool variable 
        for (int i = numOne; i <= numTwo; i++)
        {
            if (i==0)
            {
                isPrime = false; // if i ==0 the number is not prime and isPrime = false
            }
            else if (i == 1)
            {
                isPrime = false;// if i ==1 the number is not prime and isPrime = false
            }
            else // if i = 2 || i ==3 it will skip the loop and isPrime still be true;
            {
                for (int j = 2; j <= Math.Sqrt(i); j++) // creatin loop from 2 to squareRoot by i 
                {
                    if (i % j == 0)
                    {
                        isPrime = false; // check if there is a number that is devideble to i without reminder i is not prime
                        break;//if we found a number is not prime, don't have to continue looping
                    }
                }
            }
            if (isPrime==true) // if isPrime is stil true then the i is prime and Add i to List
            {
                primeNumbers.Add(i);
                
            }
            else // else i is not prime and we change isPrime to false again
            {
                isPrime = true;
            }
        }
        return primeNumbers; // return list with all prime numbers
    }
}

