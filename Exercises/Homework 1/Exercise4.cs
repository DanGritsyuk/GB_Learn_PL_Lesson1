// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

namespace Lessons
{
    public class Exercise4 : Exercise
    {
        public Exercise4(int taskNum, string description) : base(taskNum, description) { }
        public Exercise4(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }
        public override bool Solution()
        {
            string errorMessage = "Введено некорректное число.";

            Console.Write("Введите первое число (a): ");
            int a = Lessons.InputNumbers.GetObjectFromConsole<int>(errorMessage);
            Console.Write("Введите второе число (b): ");
            int b = Lessons.InputNumbers.GetObjectFromConsole<int>(errorMessage);
            Console.Write("Введите второе число (c): ");
            int c = Lessons.InputNumbers.GetObjectFromConsole<int>(errorMessage);

            Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {(a > b ? (a > c ? a : c) : (b > c ? b : c))}");

            return false;
        }
    }
}