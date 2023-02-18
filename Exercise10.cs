// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

namespace Lessons
{
    public class Exercise10 : Exercise
    {
        public Exercise10(int taskNum, string description) : base(taskNum, description) { }
        public Exercise10(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.Write("Введите число (n): ");
            int n = InputNumbers.GetNumberFromConsole(100, 999, "Введено не трехзначное число. Введите корректное: ");

            Console.WriteLine($"Вторая цифра числа {n} это {n / 10 % 10}");
        }
    }
}