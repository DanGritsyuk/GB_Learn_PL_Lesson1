// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
namespace Lesson1
{
    public class Exercise4 : Exercise
    {
        public Exercise4(int taskNum) : base(taskNum) { }
        public override void Body()
        {
            Console.Write("Введите первое число (a): ");
            int a = Lesson1.InputNumbers.GetNumberFromConsole();
            Console.Write("Введите второе число (b): ");
            int b = Lesson1.InputNumbers.GetNumberFromConsole();
            Console.Write("Введите второе число (c): ");
            int c = Lesson1.InputNumbers.GetNumberFromConsole();

            Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {(a > b ? (a > c ? a : c) : (b > c ? b : c))}");
        }
    }
}