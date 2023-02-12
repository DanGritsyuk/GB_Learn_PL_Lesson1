// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

namespace Lesson1
{
    internal class Exercise15 : Exercise
    {
        public Exercise15(int taskNum) : base(taskNum) { }

        public override void Body()
        {
            Console.Write("Введите число дня недели: ");
            int weekDay = InputNumbers.GetNumberInRangeFromConsole(1, 7, "Такого дня недели нет. Введите число от 1 до 7: ");

            Console.Write($"День {weekDay} - это {NameOfDayWeek(weekDay)}, потому ");
            if (weekDay > 5) Console.WriteLine("выходной");
            else Console.WriteLine("будний");
        }

        private string NameOfDayWeek(int dayWeek)
        {
            switch (dayWeek)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: throw new NotImplementedException();
            }
        }
    }
}