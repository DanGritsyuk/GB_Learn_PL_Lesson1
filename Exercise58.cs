// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

namespace Lessons
{
    public class Exercise58 : Exercise
    {
        public Exercise58(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            int[,] matrixA = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();
            Console.WriteLine();
            int[,] matrixB = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();

            if (ColumnsCount(matrixA) != RowsCount(matrixB))
            {
                Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                return;
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
        }

        private static int RowsCount(int[,] matrix) => matrix.GetUpperBound(0) + 1;
        private static int ColumnsCount(int[,] matrix) => matrix.GetUpperBound(1) + 1;
    }
}