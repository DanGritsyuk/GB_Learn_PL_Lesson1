// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

namespace Lessons
{
    public class Exercise50 : Exercise
    {
        public Exercise50(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override void Body()
        {
            Console.WriteLine("Введите первый индекс: ");
            int i = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:");
            Console.WriteLine("Введите второй индекс: ");
            int j = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:");

            int[,] array = GeneradeArray((new Random()).Next(1, 11), (new Random()).Next(1, 11));

            try { Console.WriteLine($"Значение: {array[i, j]}"); }
            catch { Console.WriteLine($"Такого элемента нет"); }

            Console.WriteLine();
            Console.WriteLine($"Текущий массив:");
            PrintObjects.PrintArray(array);
        }

        private int[,] GeneradeArray(int col, int row)
        {
            var array = new int[row, col];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    array[i, j] = (new Random()).Next(-100, 100);

            return array;
        }
    }
}