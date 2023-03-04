// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

namespace Lessons
{
    public class Exercise29 : Exercise
    {
        public Exercise29(int taskNum, string description) : base(taskNum, description) { }
        public Exercise29(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }
        public override void Body()
        {
            Console.Write("Введите длину массива: ");
            int lengthArray = InputNumbers.GetNumberFromConsole(0, 20, "Некорректное число или слишком большая длина. Повторите попытку:");
            int[] array = GetArrayFromConsole(lengthArray);

            PrintArray(array);
            Console.WriteLine();
        }

        private int[] GetArrayFromConsole(int length)
        {
            var array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i} значение: ");
                array[i] = InputNumbers.GetObjectFromConsole<int>("Введено некоректное число.");
            }

            return array;
        }

        private void PrintArray<T>(T[] array)
        {
            Console.Write("Массив: [ ");
            foreach (var item in array)
            {
                if (item != null)
                    Console.Write($" {item.ToString()} ");
            }
            Console.Write(" ]");
        }
    }
}