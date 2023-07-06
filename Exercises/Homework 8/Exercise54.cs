// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System.Runtime.CompilerServices;

namespace Lessons
{
    public class Exercise54 : Exercise
    {
        public Exercise54(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override bool Solution()
        {
            int[,] array = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                MergeSortAlgorithm(array, i, 0, array.GetLength(1) - 1);
            }

            PrintObjects.PrintArray<int>(array);
            return false;
        }

        private static void MergeSortAlgorithm(int[,] arr, int line, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortAlgorithm(arr, line, left, mid);
                MergeSortAlgorithm(arr, line, mid + 1, right);
                Merge(arr, line, left, mid, right);
            }
        }

        private static void Merge(int[,] arr, int line, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[line, i] >= arr[line, j])
                {
                    temp[k] = arr[line, i];
                    i++;
                }
                else
                {
                    temp[k] = arr[line, j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[line, i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[line, j];
                j++;
                k++;
            }

            for (int p = 0; p < temp.Length; p++)
            {
                arr[line, left + p] = temp[p];
            }
        }
    }
}