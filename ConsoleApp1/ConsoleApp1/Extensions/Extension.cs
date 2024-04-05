using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Extensions
{
    public static class Extension
    {

        public static bool IsPrime(this int number)
        {
            int counter = 0;
            if (number >= 2)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                    }
                }
            }
            if(counter >= 1)
                return false;

            return true;
        }
        public static void Fibonacci(this int range)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int temp;

            for (int i = 0; i < range; i++)
            {
                Console.Write($"{firstNumber} ");
                temp = firstNumber;
                firstNumber = secondNumber + firstNumber;
                secondNumber = temp;
            }
        }
        public static void Factorial(this int number)
        {
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
        public static void ConvertToFahrenheit(this double value)
        {
            double result = (value * 1.8) + 32;
            Console.WriteLine(result);
        }
        public static void ConvertToCelsius(this double value)
        {
            double result = (value - 32) * 0.5;
            Console.WriteLine(result);
        }
    }
}
