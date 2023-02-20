// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

namespace Lessons
{
    public class Exercise36 : Exercise
    {
        public Exercise36(KeyValuePair<int, string> taskData) : base(taskData) { }

        public Exercise36(int taskNum, string description) : base(taskNum, description) { }

        public override void Body()
        {
            Console.Write("Введите длину массива: ");
            var array = new int[InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:")];
            int oddIndexValuesSum = 0;

            Console.Write("Сумма нечетных индексов массива [ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (new Random()).Next(-100, 100);
                if (i % 2 != 0) oddIndexValuesSum += array[i];
                Console.Write($" {array[i]} ");
            }
            Console.Write("");
            Console.Write($"] равна: {oddIndexValuesSum}");
        }
    }
}