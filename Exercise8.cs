// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
namespace Lesson1
{
    public class Exercise8 : Exercise
    {
        public Exercise8(int taskNum) : base(taskNum) { }

        public override void Body()
        {
            Console.Write("Введите первое число (n): ");
            int n = Lesson1.InputNumbers.GetNumberFromConsole();
            if (n < 0) n = n * -1;

            if (n < 2)
                Console.Write($"{n} -> чисел нет");
            else
                Console.Write($"{n} -> 2");
            for (int i = 4; i <= n; i += 2)
                Console.Write($", {i}");
            Console.WriteLine();
        }
    }
}