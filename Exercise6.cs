// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

namespace Lessons
{
    public class Exercise6 : Exercise
    {
        public Exercise6(int taskNum, string description) : base(taskNum, description) { }
        public Exercise6(KeyValuePair<int, string> taskData) : base(taskData.Key, taskData.Value) { }

        public override void Body()
        {
            Console.Write("Введите число (a): ");
            int a = Lessons.InputNumbers.GetNumberFromConsole();

            Console.WriteLine($"{a} - {(a % 2 == 0 ? "четное" : "нечетное")}");
        }
    }
}