// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
namespace Lessons
{
    public class Exercise25 : Exercise
    {
        public Exercise25(int taskNum, string description) : base(taskNum, description) { }
        public Exercise25(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.Write("Введите число A: ");
            int a = InputNumbers.GetNumberFromConsole<int>("Введено некоректное число.");
            Console.Write("Введите число B: ");
            int b = InputNumbers.GetNumberFromConsole(0, int.MaxValue, "Число должно быть натуральным. Повторите попытку:");

            Console.WriteLine($"{a} в степени {b} равно {Exponentiation(a, b)}");
        }

        private int Exponentiation(int numberA, int numberB)
        {
            int result = 1;
            for (int i = 1; i <= numberB; i++)
            {
                result = result * numberA;
            }
            return result;
        }
    }
}