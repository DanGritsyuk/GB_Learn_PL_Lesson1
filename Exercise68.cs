// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

namespace Lessons
{
    public class Exercise68 : Exercise
    {
        public Exercise68(KeyValuePair<int, string> taskData) : base(taskData) { }
        delegate int Solution(int n, int m);

        public override void Body()
        {
            string errorMessage = "Введено некоректное число. Введите другое: ";
            Console.Write("Введите первое число (N): ");
            int n = InputNumbers.GetObjectFromConsole<int>(errorMessage);
            Console.Write("Введите первое число (M): ");
            int m = InputNumbers.GetObjectFromConsole<int>(errorMessage);

            Solution ackermann = CheckSolution();
            Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {ackermann(n, m)}");

        }

        private int AckermannRec(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else if (m == 0)
                return AckermannRec(n - 1, 1);
            else
                return AckermannRec(n - 1, AckermannRec(n, m - 1));
        }
        private int AckermannItRec(int n, int m)
        {
            while (n != 0)
            {
                if (m == 0) m = 1;
                else m = AckermannItRec(n, m - 1);
                n--;
            }
            return m + 1;
        }

        private Solution CheckSolution()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите способ вычисления:");
            int answer = Lessons.StartMenu.GetMenu(new string[] { "Рекурсивный.", "Итерационно-рекурсивный." }, false, false);
            return answer == 1 ? AckermannRec : AckermannItRec;
        }


    }
}