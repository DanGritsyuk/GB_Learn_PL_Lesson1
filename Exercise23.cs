// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

namespace Lessons
{
    public class Exercise23 : Exercise
    {
        public Exercise23(int taskNum) : base(taskNum) { }

        public override void Body()
        {
            Console.Write("Введите число (n): ");
            int n = Lessons.InputNumbers.GetNumberFromConsole();

            if (n < 1)
                Console.Write($"{n} -> чисел нет");
            else
                Console.Write($"{n} -> 1");
            for (int i = 2; i <= n; i++)
            {
                Console.Write($", {i * i * i}");
            }
        }
    }
}