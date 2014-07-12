using System;

class SortNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // get the number n 
        int[] sortNumbers = new int[n];//creating an array with length n
        for (int i = 0; i < sortNumbers.Length; i++)
        {
            sortNumbers[i] = int.Parse(Console.ReadLine()); // get n numbers and assume them to array
        }
        Array.Sort(sortNumbers);//sort array
        foreach (var num in sortNumbers)
        {
            Console.WriteLine(num);//print sorted array
        } 
        
    }
}

