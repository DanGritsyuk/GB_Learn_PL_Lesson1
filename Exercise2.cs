// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

namespace Lessons
{
    public class Exercise2 : Exercise
    {
        public Exercise2(int taskNum, string description) : base(taskNum, description) { }
        public Exercise2(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }
        public override void Body()
        {
            Console.Write("Введите первое число (a): ");
            int a = Lessons.InputNumbers.GetNumberFromConsole();
            Console.Write("Введите второе число (b): ");
            int b = Lessons.InputNumbers.GetNumberFromConsole();

            Console.WriteLine($"a = {a}; b = {b} -> max = {(a > b ? a : b)}");
        }
    }
}