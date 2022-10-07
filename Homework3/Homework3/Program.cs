using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double l = 0;

            Console.WriteLine("We're going to calculate length of a vector.");
            Console.WriteLine("Specify the abscissa of the first point:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Specify the ordinate of the first point:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Specify the abscissa of the second point:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Specify the ordinate of the second point:");
            y2 = Convert.ToDouble(Console.ReadLine());

            l = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("The length of the vector = " + l);
        }
    }
}
