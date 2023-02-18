// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

namespace Lessons
{
    public class Exercise4 : Exercise
    {
        public Exercise4(int taskNum) : base(taskNum) { }
        public override void Body()
        {
            Console.Write("Введите первое число (a): ");
            int a = Lessons.InputNumbers.GetNumberFromConsole();
            Console.Write("Введите второе число (b): ");
            int b = Lessons.InputNumbers.GetNumberFromConsole();
            Console.Write("Введите второе число (c): ");
            int c = Lessons.InputNumbers.GetNumberFromConsole();

            Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {(a > b ? (a > c ? a : c) : (b > c ? b : c))}");
        }
    }
}