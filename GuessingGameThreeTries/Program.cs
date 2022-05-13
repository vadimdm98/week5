using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {

            //Игра *угадай номер*
            //Программа генерует случайное число от 1 до 10
            //программа предлагает пользователя угадать это число
            //Пользователь пытается угадать это число 
            //Если пользователь угадал число, программа поздравляет его с победой
            //У пользователя ровно 3 попытки
            //Если пользователь не угадал число за 3 попытки, программа объявляет победителем компьютер
            //*случайное число генерируется только один раз
            Random rnd = new Random();
            int i = rnd.Next(1, 11);
            int tries = 0;
            int userNumber;

            //Console.WriteLine($"{i}");
            //Console.WriteLine(" ");

            Console.WriteLine("Game *guess the number*");
            Console.WriteLine(" ");
            Console.WriteLine("The program generates a random number from 1 to 10.");
            Console.WriteLine("Guess the number. You have three attempts.");
            Console.WriteLine(" ");

            while (tries != 3)
            {
                Console.WriteLine($"Attempt № {tries + 1}. Enter the number:");

                userNumber = Convert.ToInt32(Console.ReadLine());
                tries++;

                if (i == userNumber)
                {
                    Console.WriteLine($"Guessed! This number " + userNumber + "!");

                    break;
                }

                else
                {
                    if (tries == 3)
                    {
                        Console.WriteLine("not right");
                        Console.WriteLine(" ");
                        Console.WriteLine("Unfortunately, you did not guess the hidden number. It was a number " + i + "!");
                        Console.WriteLine("won the computer");
                        break;
                    }

                    Console.WriteLine("Didn't guess.");
                    Console.WriteLine($"you had {tries} attempt. try again");
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day!");
        }
    }
}
