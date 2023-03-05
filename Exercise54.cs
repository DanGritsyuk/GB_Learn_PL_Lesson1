// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

namespace Lessons
{
    public class Exercise54 : Exercise
    {
        public Exercise54(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            int[,] array = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    for (int j = 0; j < array.GetLength(1) - 1; j++)
                    {
                        if (array[i, j] < array[i, j + 1])
                            (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                    }
                }
            }

            PrintObjects.PrintArray<int>(array);
        }
    }
}