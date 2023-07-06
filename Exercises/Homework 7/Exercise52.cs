// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


namespace Lessons
{
    public class Exercise52 : Exercise
    {
        public Exercise52(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override bool Solution()
        {
            int[,] valuesArray = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();
            double[] averageArray = new double[valuesArray.GetLength(1)];

            for (int j = 0; j < averageArray.Length; j++)
            {
                double sum = 0;
                for (int i = 0; i < valuesArray.GetLength(0); i++)
                    sum += (double)valuesArray[i, j];
                averageArray[j] = Math.Round((sum / (double)valuesArray.GetLength(0)), 1);
            }

            Console.Write("Средне арифметическое столбцов массива: ");
            PrintObjects.PrintArray<double>(averageArray);

            return false;
        }
    }
}