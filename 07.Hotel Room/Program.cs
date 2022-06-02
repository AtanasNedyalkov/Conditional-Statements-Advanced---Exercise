using System;

namespace _07.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApart = 0;
            if (month == "May" || month == "Octobre")
            {
                priceStudio = nights * 50;
                priceApart = nights * 65;

                if (nights>14)
                {
                    priceStudio = priceStudio - priceStudio * 0.30;
                    priceApart = priceApart - priceApart * 0.10;
                    
                }
                else if (nights>7)
                {
                    priceStudio = priceStudio - priceStudio * 0.05;

                }
            }
            else if ((month == "June" || month == "September"))
            {
                priceStudio = nights * 75.20;
                priceApart = nights * 68.70;

                if (nights>14)
                {
                    priceStudio = priceStudio - priceStudio * 0.20;
                    priceApart = priceApart - priceApart * 0.10;
                }
            }
            else
            {
                priceStudio = nights * 76;
                priceApart = nights * 77;

                if (nights > 14)
                {
                    priceApart = priceApart - priceApart * 0.10;
                }
            }
            Console.WriteLine($"Apartment: {priceApart:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
