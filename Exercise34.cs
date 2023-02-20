// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных

namespace Lessons
{
    public class Exercise34 : Exercise
    {
        public Exercise34(int taskNum, string description) : base(taskNum, description) { }
        public Exercise34(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.Write("Введите длину массива: ");
            var array = new int[InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:")];
            int evenCount = 0;

            Console.Write("В массиве [ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (new Random()).Next(100, 1000);
                if (array[i] % 2 == 0) evenCount++;
                Console.Write($" {array[i]} ");
            }
            Console.Write("] -> ");
            if (evenCount == 0) Console.Write("Нет четных чисел");
            else Console.Write($"четных чисел: {evenCount}");
        }
    }
}