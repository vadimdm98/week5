﻿using System;

namespace SumOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа генерирует 10 случайных чисел (от 1 до 10), ввыводит их значение на экран
            // программа подсчитывает сумму этих чисел и выводит сумму на экран
            int sum = 0;
            int i = 0; // i - iteration - итерация
            Random rnd = new Random();
            while (i != 10)
            {
                int NewRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Step {i + 1}. Generated {NewRandomNumber}");
                sum = sum + NewRandomNumber;
                i++;
            }
            Console.WriteLine($"Sum of 10 random numbers is: {sum}");
        }
    }
}
