// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

namespace Lessons
{
    public class Exercise60 : Exercise
    {
        public Exercise60(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            int n, m, h;
            while (true)
            {
                Console.Write("Введите первый размер (i): ");
                n = Lessons.InputNumbers.GetObjectFromConsole<int>("Введено некоректное число.");
                Console.Write("Введите второй размер (j): ");
                m = Lessons.InputNumbers.GetObjectFromConsole<int>("Введено некоректное число.");
                Console.Write("Введите третий размер (h): ");
                h = Lessons.InputNumbers.GetObjectFromConsole<int>("Введено некоректное число.");

                if (n * m * h < 100)
                    break;
                Console.WriteLine("массив слишком велик, нельзя записать неповторяющиеся двухзначные числа.");
            }
            PrintArray(FillArray(n, m, h));
        }

        private int[,,] FillArray(int n, int m, int h)
        {
            int[,,] array = new int[n, m, h];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        while (true)
                        {
                            int num = new Random().Next(10, 100);
                            foreach (var item in array)
                                if (item == num) continue;
                            array[i, j, k] = num;
                            break;
                        }
                    }

            return array;
        }
        private void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"({i}, {j}, {k}){array[i, j, k]}; ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}