// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

namespace Lessons
{
    public class Exercise58 : Exercise
    {
        public Exercise58(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override bool Solution()
        {
            int[,] matrixA = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();
            Console.WriteLine();
            int[,] matrixB = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();

            if (ColumnsCount(matrixA) != RowsCount(matrixB))
            {
                Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                return false;
            }

            var matrixC = new int[RowsCount(matrixA), ColumnsCount(matrixB)];

            for (var i = 0; i < RowsCount(matrixA); i++)
            {
                for (var j = 0; j < ColumnsCount(matrixB); j++)
                {
                    matrixC[i, j] = 0;
                    for (var k = 0; k < ColumnsCount(matrixA); k++)
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }

            PrintObjects.PrintArray(matrixC);

            return false;
        }

        // эти методы для того чтобы не запутаться :)
        private static int RowsCount(int[,] matrix) => matrix.GetLength(0); // получаем количество строк
        private static int ColumnsCount(int[,] matrix) => matrix.GetLength(1); // получаем количество столбцов
    }
}