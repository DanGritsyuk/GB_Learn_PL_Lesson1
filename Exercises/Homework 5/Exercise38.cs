// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System.Text;

namespace Lessons
{
    public class Exercise38 : Exercise
    {
        public Exercise38(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override bool Solution()
        {
            Console.Write("Введите длину массива: ");
            var array = new float[InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:")];
            float min, max;
            var errorMessage = "Введено некорректное число.";

            Console.Write("Введите 0 элемент: ");
            array[0] = min = max = InputNumbers.GetObjectFromConsole<float>(errorMessage);

            StringBuilder answerToConsole = new StringBuilder("Разница между минимальным и максимальным значениями массива [ ");
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write($"Введите {i} элемент: ");
                array[i] = InputNumbers.GetObjectFromConsole<float>(errorMessage);
                if (array[i] < min) min = array[i];
                else if (array[i] > max) max = array[i];
                answerToConsole.Append($" {array[i]} ");
            }
            Console.WriteLine($"{answerToConsole.ToString()} ] равна: {max - min}");

            return false;
        }
    }
}