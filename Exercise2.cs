// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

namespace Lessons
{
    public class Exercise2 : Exercise
    {
        public Exercise2(int taskNum, string description) : base(taskNum, description) { }
        public Exercise2(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }
        public override void Body()
        {
            string errorMessage = "Введено некоректное число.";

            Console.Write("Введите первое число (a): ");
            int a = Lessons.InputNumbers.GetObjectFromConsole<int>(errorMessage);
            Console.Write("Введите второе число (b): ");
            int b = Lessons.InputNumbers.GetObjectFromConsole<int>(errorMessage);

            Console.WriteLine($"a = {a}; b = {b} -> max = {(a > b ? a : b)}");
        }
    }
}