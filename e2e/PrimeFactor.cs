
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] textArray = System.IO.File.ReadAllLines("~//file.txt");
        //ToDo - check if validate path
        //ToDO - check if file format is correct(opening or not) Assuming it is a txt file.
        foreach (string eachLine in textArray)
        {
            {
                if (long.TryParse(eachLine, out long x))
                {
                    Console.Write(eachLine + "  -  ");
                    CalculatePrimeFactors(x);
                }
                else
                {
                    Console.Write(eachLine + "  -  ");
                    Console.WriteLine("Not a valid Integer");
                }
            }
        }
    }
    static void CalculatePrimeFactors(long num)
    {
        List<long> result = new List<long>();

        while (num % 2 == 0)        // Take out the 2s.
        {
            result.Add(2);
            num /= 2;
        }

        long factor = 3;         // Take out other primes.

        while (factor * factor <= num)
        {

            if (num % factor == 0)
            {
                result.Add(factor);         // This is a factor.
                num /= factor;
            }
            else
            {
                factor += 2;        // Go to the next odd number.
            }
        }
        if (num > 1) result.Add(num);       // If num is not 1, then whatever is left is prime.

        Write(result);
    }

    private static void Write(List<long> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            if (i == result.Count - 1)
            {
                Console.Write(result[i]);
            }
            else
            {
                Console.Write(result[i] + ", ");
            }
        }
        int count = result.Count;

        Console.WriteLine("");
    }
}