using System;

namespace Practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            Console.WriteLine("Enter value for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for d");
            d = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine("a is max: " + a);
                        // b c d a
                    }
                    else
                    {
                        Console.WriteLine("d is max: " + d);
                        // b c a d
                    }
                    
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("c is max: " + c);
                        // b a d c
                    }
                    else
                    {
                        Console.WriteLine("d is max: " + d);
                        // b a c d
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("b is max: " + b);
                        // a c d b
                    }
                    else
                    {
                        Console.WriteLine("d is max: " + d);
                        // a c b d
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("c is max: " + c);
                        // a b d c
                    }
                    else
                    {
                        Console.WriteLine("d is max: " + d);
                        // a b c d
                    }

                }
            }


        }
    }
}
