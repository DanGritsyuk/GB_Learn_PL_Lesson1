// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

namespace Lessons
{
    public class Exercise64 : Exercise
    {
        public Exercise64(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override bool Solution()
        {
            Console.Write("Введите первое число (N): ");
            int n = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Введено некорректное число. Введите другое: ");
            Console.WriteLine($"N={n} -> \"{CountdownRec(n)}");
            return false;
        }

        private string CountdownRec(int n) => n == 1 ? "1\"" : $"{n}, {CountdownRec(n - 1)}";
    }
}