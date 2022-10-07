using System;

namespace Practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double p = 0;
            double S = 0;

            Console.WriteLine("We're going to calculate square of triangle");
            Console.WriteLine("Enter value for a:");
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Value for a must be positive!");
            }
            else
            {
                Console.WriteLine("Enter value for b:");
                b = Convert.ToDouble(Console.ReadLine());
            }

            if (b <= 0)
            {
                Console.WriteLine("Value for b must be positive!");
            }
            else
            {
                Console.WriteLine("Enter value for c:");
                c = Convert.ToDouble(Console.ReadLine());
            }

            if (c <= 0)
            {
                Console.WriteLine("Value for c must be positive!");
            }
            else
            {
                if ((a + b) <= c)
                {
                    Console.WriteLine("This triangle doesn't exist. Please, try again.");
                }
                else
                {
                    p = (a + b + c) / 2;
                    S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("Square of the triangle = " + S);
                }
            }
        }
    }
}
