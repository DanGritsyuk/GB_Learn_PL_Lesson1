// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

namespace Lessons
{
    internal class Exercise13 : Exercise
    {
        public Exercise13(int taskNum, string description) : base(taskNum, description) { }
        public Exercise13(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.Write("Введите число (n): ");
            int n = InputNumbers.GetNumberFromConsole<int>("Введено некоректное число.");

            Console.Write($"{n} -> ");
            if (n > 99)
            {
                while (n > 999)
                    n /= 10;
                n %= 10;
                Console.WriteLine($"Третья цифра {n}");
            }
            else
                Console.WriteLine($"Третьей цифры нет");
        }
    }
}