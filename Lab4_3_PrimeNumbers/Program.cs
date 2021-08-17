using System;

namespace Lab4_3_PrimeNumbers
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }

            if (num % 2 == 0)
            {
                return false;
            }

            if (num == 3)
            {
                return true;
            }

            if (num % 3 == 0)
            {
                return false;
            }

            if (num == 5)
            {
                return true;
            }

            if (num % 5 == 0)
            {
                return false;
            }

            return true;
        }
    }
    public class Program
    {


        public static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (PrimeNumbers.IsPrime(num))
            {
                Console.WriteLine($"{num} is prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }


        }
    }
}
