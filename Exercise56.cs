//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

namespace Lessons
{
    public class Exercise56 : Exercise
    {
        public Exercise56(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            int[,] array = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();

            int lineIndex = 0;
            int? sumMin = null;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    sum += array[i, j];
                if (sumMin == null)
                {
                    sumMin = sum;
                }
                else if (sum < sumMin.Value)
                {
                    sumMin = sum;
                    lineIndex = i;
                }
            }

            Console.WriteLine($"{lineIndex + 1}-я строка с наименьшей суммой элементов.");
        }
    }
}