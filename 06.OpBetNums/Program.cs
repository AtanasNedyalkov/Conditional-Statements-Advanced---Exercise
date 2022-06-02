using System;

namespace _06.OpBetNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double  num2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double result = 0;
            if (sign == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {sign} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {sign} {num2} = {result} - odd");
                }
            }
            else if (sign == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {sign} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {sign} {num2} = {result} - odd");
                }
            }
            else if (sign == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {sign} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {sign} {num2} = {result} - odd");
                }
            }
            else if (sign == "/")
            {
                if (num1 == 0  || num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} {sign} {num2} = {result:F2}");
                }
            }
            else
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {sign} {num2} = {result}");
                }
            }
            
        }
    }
}
