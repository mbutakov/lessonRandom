using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int lenghtArray;
        private static int[] standartArray;
        private static int[] newArray;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //Задаем тексту цвет
            Console.WriteLine("Введите длину массива");
            Console.ResetColor(); //сносим цвет
            lenghtArray = Int32.Parse(Console.ReadLine());
            standartArray = new int[lenghtArray];
            Console.ForegroundColor = ConsoleColor.Yellow; //Задаем тексту цвет
            Console.WriteLine("Заполните массив в одной строке через пробел длиной в: " + lenghtArray + " элементов");
            Console.ResetColor(); //сносим цвет
            string[] stringNums = Console.ReadLine().Split(" ");
            for (int i = 0; i < lenghtArray; i++)
            {
                standartArray[i] = Int32.Parse(stringNums[i]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow; //Задаем тексту цвет
            Console.WriteLine("Введите промежуток элементов от" + " 1 " + "до " + standartArray.Length + " в одной строке через - ,для составления нового массива");
            Console.WriteLine("Пример ввода: " + "3-5");
            Console.ResetColor(); //сносим цвет
            string[] range = Console.ReadLine().Split("-");
            int firstRangeZero = Int32.Parse(range[0]) -1;
            int secondRangeZero = Int32.Parse(range[1]);
            if(secondRangeZero > standartArray.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Диапазон указан неверно. Таких элементов не существует.");
                Console.WriteLine("Программа завершена");
                Console.ResetColor(); //сносим цвет
                Console.ReadKey();
            }
            else if (firstRangeZero+1 < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Диапазон указан неверно. Таких элементов не существует.");
                Console.WriteLine("Программа завершена");
                Console.ResetColor(); //сносим цвет
                Console.ReadKey();
            }
            int countElement = secondRangeZero - firstRangeZero;
            newArray = new int[countElement];
            for (int j = 0; j < countElement; j++)
            {
                newArray[j] = standartArray[firstRangeZero + j];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш новый массив:");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int g = 0; g < newArray.Length; g++)
            {
                Console.Write(newArray[g] + " ");
            }
            Console.ResetColor(); //сносим цвет
        }
    }
}
