using System;

namespace Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of mirror");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                string c = "";
                string s = "  ";

                for (int j = 0; j < i * 4; j++)
                {
                    c += ".";
                }
                for (int j = (size - i - 2) * 2; j >= 0; j--)
                {
                    s += " ";
                }
                Console.Write(s + "|<>");
                Console.WriteLine(c + "<>|");
            }
            for (int i = size - 1; i >= 0; i--)
            {
                string c = "";
                string s = "  ";
                for (int j = 0; j < i * 4; j++)
                {
                    c += ".";
                }
                for (int j = 0; j <= (size - i - 2) * 2; j++)
                {
                    s += " ";
                }
                Console.Write(s + "|<>");
                Console.WriteLine(c + "<>|");
            }
        }
    }
}