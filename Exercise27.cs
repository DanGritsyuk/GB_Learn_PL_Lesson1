// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

namespace Lessons
{
    public class Exercise27 : Exercise
    {
        public Exercise27(int taskNum, string description) : base(taskNum, description) { }
        public Exercise27(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }
        public override void Body()
        {
            Console.Write("Введите число: ");
            int n = InputNumbers.GetNumberFromConsole();

            Console.WriteLine($"Сумма цифр числа {n} равна {GetSumDigits(n)}");
        }

        private int GetSumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}