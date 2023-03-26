// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

namespace Lessons
{
    public class Exercise66 : Exercise
    {
        public Exercise66(KeyValuePair<int, string> taskData) : base(taskData) { }
        public override void Body()
        {
            string errorMessage = "Введено некоректное число. Введите другое: ";
            Console.Write("Введите первое число (N): ");
            int n = InputNumbers.GetObjectFromConsole<int>(errorMessage);
            Console.Write("Введите первое число (M): ");
            int m = InputNumbers.GetObjectFromConsole<int>(errorMessage);

            Console.WriteLine(SumRec(n, m));
        }

        private int SumRec(int n, int m) => n >= m ? m : n + m + SumRec(n + 1, m - 1);
    }
}