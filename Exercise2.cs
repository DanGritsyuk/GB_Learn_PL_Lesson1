// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

namespace Lesson1
{
    public class Exercise2 : Exercise
    {
        public Exercise2(int taskNum) : base(taskNum) { }
        public override void Body()
        {
            Console.Write("Введите первое число (a): ");
            int a = Lesson1.InputNumbers.GetNumberFromConsole();
            Console.Write("Введите второе число (b): ");
            int b = Lesson1.InputNumbers.GetNumberFromConsole();

            Console.WriteLine($"a = {a}; b = {b} -> max = {(a > b ? a : b)}");
        }
    }
}