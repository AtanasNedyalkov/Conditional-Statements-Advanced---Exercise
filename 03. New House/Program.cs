using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            int narcissus = 3;
            double gladiolus = 2.50;
            double totalPrice = 0;
            if (flowers == "Roses" )
            {
                if (numOfFlowers > 80)
                {
                    double price = numOfFlowers * 5;
                    totalPrice = price - price * 0.1;
                }
                else
                {
                    totalPrice = numOfFlowers * 5;
                }
            }
            else if (flowers == "Dahlias" )
            {
                if (numOfFlowers > 90)
                {
                    double price = numOfFlowers * 3.80;
                    totalPrice = price - price * 0.15;
                }
                else
                {
                    totalPrice = numOfFlowers * 3.80;
                }
            }
            else if (flowers == "Tulips"  )
            {
                if (numOfFlowers > 80)
                {
                    double price = numOfFlowers * 2.80;
                    totalPrice = price - price * 0.15;
                }
                else
                {
                    totalPrice = numOfFlowers * 2.80;
                }
            }
            else if (flowers == "Narcissus" )
            {
                if (numOfFlowers < 120)
                {
                    double price = numOfFlowers * 3;
                    totalPrice = price + price * 0.15;
                }
                else
                {
                    totalPrice = numOfFlowers * 3;
                }
            }
            else if (flowers == "Gladiolus" )
            {
                if (numOfFlowers < 80)
                {
                    double price = numOfFlowers * 2.50;
                    totalPrice = price + price * 0.2;
                }
                else
                {
                    totalPrice = numOfFlowers * 2.50;
                }
            }
            double difference = totalPrice - budget;
            if (totalPrice>budget)
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {Math.Abs(difference):f2} leva left.");
            }
        }
    }
}
