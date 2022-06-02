using System;

namespace _04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFisherMan = int.Parse(Console.ReadLine());
            double price = 0;
            //"Spring", "Summer", "Autumn", "Winter"

            //•	Цената за наем на кораба през пролетта е  3000 лв.
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            //•	Цената за наем на кораба през зимата е  2600 лв.

            if (season == "Spring")
            {
                if (numOfFisherMan <= 6)
                {
                    price = 3000 - 3000 * 0.10;
                }
                else if (numOfFisherMan >= 7 && numOfFisherMan <= 11)
                {
                    price = 3000 - 3000 * 0.15;
                }
                else
                {
                    price = 3000 - 3000 * 0.25;
                }
            }
            else if (season == "Summer")
            {
                if (numOfFisherMan <= 6)
                {
                    price = 4200 - 4200 * 0.10;
                }
                else if (numOfFisherMan >= 7 && numOfFisherMan <= 11)
                {
                    price = 4200 - 4200 * 0.15;
                }
                else
                {
                    price = 4200 - 4200 * 0.25;
                }
            }
            else if (season == "Autumn")
            {
                if (numOfFisherMan <= 6)
                {
                    price = 4200 - 4200 * 0.10;
                }
                else if (numOfFisherMan >= 7 && numOfFisherMan <= 11)
                {
                    price = 4200 - 4200 * 0.15;
                }
                else
                {
                    price = 4200 - 4200 * 0.25;
                }
            }
            else if (season == "Winter")
            {
                if (numOfFisherMan <= 6)
                {
                    price = 2600 - 2600 * 0.10;
                }
                else if (numOfFisherMan >= 7 && numOfFisherMan <= 11)
                {
                    price = 2600 - 2600 * 0.15;
                }
                else
                {
                    price = 2600 - 2600 * 0.25;
                }
            }
            if (season != "Autumn" && numOfFisherMan % 2 == 0)
            {
                price = price - price * 0.05;
            }
            if (budget>=price)
            {
                Console.WriteLine($"Yes! You have {(budget-price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):F2} leva.");
            }



        }
    }
}
