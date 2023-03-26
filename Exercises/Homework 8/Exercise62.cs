// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

namespace Lessons
{
    public class Exercise62 : Exercise
    {
        public Exercise62(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            Console.Write("Введите размер массива (не менее 4): ");
            int n = InputNumbers.GetNumberFromConsole(4, int.MaxValue, "Некорректное число. Повторите попытку:");
            int[,] array = new int[n, n];

            int argument = 1;
            int i = 0;
            int j = 0;

            while (argument <= n * n)
            {
                array[i, j] = argument++;
                if (i <= j + 1 && i + j < n - 1)
                    j++;
                else if (i < j && i + j >= n - 1)
                    i++;
                else if (i >= j && i + j > n - 1)
                    j--;
                else
                    i--;
            }

            PrintObjects.PrintArray<int>(array);
        }
    }
}