using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_Homework_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Задание 1.Случайная матрица
            //Что нужно сделать
            //Выведите на экран матрицу заданного размера и заполните её случайными числами.Детальный алгоритм работы приложения:

            //Сначала пользователю предлагается ввести количество строк в будущей матрице.
            //Затем — ввести количество столбцов в будущей матрице.
            //Когда данные будут получены, нужно создать в памяти матрицу заданного размера.
            //Используя Random, заполнить матрицу случайными целыми числами.
            //Вывести полученную матрицу на экран.
            //Вывести сумму всех элементов этой матрицы на экран отдельной строкой.
            //Рекомендация
            //Для работы с матрицами используйте вложенные циклы.

            //Что оценивается
            //Программа выводит на экран случайно созданную матрицу предварительно заданного размера, а также сумму всех элементов в ней.

            Console.WriteLine("Случайная матрица");
            Console.WriteLine("Введите желаемое количество строк и столбцов!\n");

            Console.Write("Введите количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write(("Введите количество столбцов: "));
            int columns = int.Parse(Console.ReadLine());

            int sum = 0;

            int[,] array = new int[line, columns];

            Random rand = new Random();

            for (int i = 0; i < line; i++)
                {
                for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = rand.Next(10);
                        Console.Write($" {array[i, j]}");
                    }
                Console.WriteLine();
                }

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine();                
            }
            Console.WriteLine($"Cуммa всех элементов этой матрицы: {sum}");
            Console.ReadKey();
        

        }
    }
}
