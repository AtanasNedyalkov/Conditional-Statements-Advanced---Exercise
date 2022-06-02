using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int collums = int.Parse(Console.ReadLine());
            double income = 0;
            if (type == "Premiere")
            {
                income = collums * rows * 12;
            }
            else if (type == "Normal")
            {
                income = collums * rows * 7.5;
            }
            else
            {
                income = collums * rows * 5;
            }
            Console.WriteLine($"{income:f2}");
        }
    }
}
