// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

namespace Lessons
{
    public class Exercise47 : Exercise
    {
        public Exercise47(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override void Body()
        {
            Console.WriteLine("Введите длину массива: ");
            int col = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:");
            Console.WriteLine("Введите высоту массива: ");
            int row = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:");
            var array = new int[row, col];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    array[i, j] = (new Random()).Next(-100, 100);

            PrintObjects.PrintArray(array);
        }
    }
}