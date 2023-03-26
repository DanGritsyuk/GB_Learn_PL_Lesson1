// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

namespace Lessons
{
    public class Exercise19 : Exercise
    {
        public Exercise19(int taskNum, string description) : base(taskNum, description) { }
        public Exercise19(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.Write("Введите пятизначное число: ");
            int copyNumber, number = copyNumber = InputNumbers.GetNumberFromConsole(10000, 99999, "Введено не пятизначное число. Повторите попытку: ");

            int reverceNumber = 0;
            while (copyNumber > 0)
            {
                reverceNumber = reverceNumber * 10 + copyNumber % 10;
                copyNumber /= 10;
            }

            Console.WriteLine($"Число {number} {(number == reverceNumber ? "палиндром" : "не палиндром")}");
        }
    }
}