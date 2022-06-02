using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfHousing = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                    typeOfHousing = "Camp";
                }
                else
                {
                    price = budget * 0.7;
                    typeOfHousing = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                    typeOfHousing = "Camp";
                }
                else
                {
                    price = budget * 0.8;
                    typeOfHousing = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                price = budget * 0.9;
                typeOfHousing = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHousing} - {price:F2}");
        }
    }
}
