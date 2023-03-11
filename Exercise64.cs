// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

namespace Lessons
{
    public class Exercise64 : Exercise
    {
        public Exercise64(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            Console.Write("Введите первое число (n): ");
            int n = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Введено некоректное число. Введите другое: ");
            Console.WriteLine($"N={n} -> \"{СountdowRec(n)}");
        }
        private string СountdowRec(int n) => n == 1 ? "1\"" : $"{n}, {СountdowRec(n - 1)}";
    }
}