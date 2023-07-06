/*
**Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
*/

namespace Lessons
{
    public class Exercise57 : Exercise
    {
        public Exercise57(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override bool Solution()
        {
            int defaultElement = 0;
            int[,] array = InputNumbers.GetTwoDimensionalArrayFromConsole<int>();
            int countDefaultElement = GetCountArrayElement(defaultElement, array);

            if (countDefaultElement > 0) { PrintCountArrayElement(defaultElement, countDefaultElement); }

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] != 0)
                        PrintCountArrayElement(array[i, j], GetCountArrayElement(array[i, j], array));
            return false;
        }

        private int GetCountArrayElement(int item, int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (item == array[i, j])
                    {
                        if (item != 0) { array[i, j] = 0; }
                        count++;
                    }
            return count;
        }

        private void PrintCountArrayElement(int element, int count) =>
            Console.WriteLine($"Значение {element} присутствует в массиве: {count}");
    }
}