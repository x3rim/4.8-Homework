using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_Homework_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Задание 2.Сложение матриц
            //Что нужно сделать
            //Используя размеры матрицы из предыдущего задания, создайте ещё одну матрицу.Сложите две матрицы.

            //Сложение матриц А и В — это нахождение такой матрицы С, все элементы которой представляют собой сложенные попарно соответствующие элементы исходных матриц А и В.
            //Складывать допускается только матрицы одинаковой размерности(допустим, m × n), то есть имеющие равное количество строк и равное количество столбцов.

            //Таким образом, математически сумма матриц выглядит так:

            //Аm×n + Bm×n = Cm×n

            //Каждый элемент искомой матрицы равен сумме соответствующих элементов заданных матриц:

            //            cij = aij + bij,

            //где i принимает значение от 1 до m, j имеет значение от 1 до n.

            //Рассмотрим пример сложения двух матриц размера 2 × 3.

            //Даны две матрицы:



            //            Необходимо найти сумму матриц А и В.

            //            Решение:



            //Выведите на экран полученную матрицу.

            //Что оценивается
            //Программа выводит на экран две случайные матрицы и их сумму.


            Console.WriteLine("Случайная матрица");
            Console.WriteLine("Введите желаемое количество строк и столбцов!\n");

            Console.Write("Введите количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write(("Введите количество столбцов: "));
            int columns = int.Parse(Console.ReadLine());

            int[,] arrayA = new int[line, columns];

            Random randomaiser = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayA[i, j] = randomaiser.Next(10);
                    Console.Write($" {arrayA[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] arrayB = new int[line, columns];

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayB[i, j] = randomaiser.Next(10);
                    Console.Write($" {arrayB[i, j]}");
                }
                Console.WriteLine();
            }   
                Console.WriteLine();
                Console.WriteLine();

                int[,] arrayC = new int[line, columns];

                for (int n = 0; n < line; n++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        arrayC[n, j] = arrayA[n, j] + arrayB[n, j];
                        Console.Write($" {arrayC[n, j]}");
                    }

                    Console.WriteLine();
                              
                }
            

            Console.ReadKey();
        }

    }
}
