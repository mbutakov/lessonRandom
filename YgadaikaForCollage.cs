using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGADAIKA
{
    class Program
    {
        private static Random rnd = new Random();
        private static int numberPc;
        private static int chanceCount = 3;
        private static bool isWin;
        private static bool gameOver = false;
        static void Main(string[] args)
        {
            numberPc = rnd.Next(1, 11);
            Console.WriteLine("Введи число от 1 до 10");
            if (chanceCount == 3)
            {
                StartGame();
            }
            while (isWin == true && gameOver == false)
            {
                if (isWin == true)
                {
                    Console.WriteLine("Ты выйграл" +
                        ",Хочешь начать игру заного? да / нет");
                    String сhoice = Console.ReadLine();
                    if (сhoice.Equals("да") || сhoice.Equals("ДА") || сhoice.Equals("Да") || сhoice.Equals("дА"))
                    {
                        numberPc = rnd.Next(1, 11);
                        Console.WriteLine("Введи число");
                        Console.WriteLine("Я поменял число");
                        Console.WriteLine("Желаю удачи в этой " +
                            "игре");
                        Console.WriteLine("Введи число");
                        chanceCount = 3;
                        isWin = false;
                        StartGame();
                    }
                    else
                    {
                        gameOver = true;
                        Console.WriteLine("Пока!");
                    }
                }
            }
            if (chanceCount == 0 && isWin == false && gameOver == false)
            {
                Console.WriteLine("Ты проиграл число было " + numberPc + " Хочешь начать игру заного? да / нет");
                String сhoice = Console.ReadLine();
                if (сhoice.Equals("да") || сhoice.Equals("ДА") || сhoice.Equals("Да") || сhoice.Equals("дА"))
                {
                    numberPc = rnd.Next(1, 11);
                    Console.WriteLine("Введи число");
                    Console.WriteLine("Я поменял число");
                    Console.WriteLine("Желаю удачи в этой игре");
                    Console.WriteLine("Введи число");
                    chanceCount = 3;
                    StartGame();
                }
                else
                {
                    gameOver = true;
                    Console.WriteLine("Пока!");
                }
            }
            Console.ReadKey();
        }

        private static void StartGame()
        {
            while (chanceCount > 0 && isWin == false && gameOver == false)
            {
                chanceCount--;
                int numberUser = int.Parse(Console.ReadLine());
                if (numberUser == numberPc)
                {
                    isWin = true;
                    chanceCount = 0;
                }
                else if (numberUser > numberPc)
                {
                    Console.WriteLine("Моё число меньше");
                }
                else if (numberUser < numberPc)
                {
                    Console.WriteLine("Моё число больше");
                }
            }
        }

    }
}
