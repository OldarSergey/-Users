﻿using System;
namespace Factorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше число:");
            long i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал вашего числа равен: {Factorial(i)}") ;
        }
        public static long Factorial(long value)
        {
            if (value <= 1)
            {
                return 1;

            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}