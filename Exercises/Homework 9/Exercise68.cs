// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

namespace Lessons
{
    public class Exercise68 : Exercise
    {
        public Exercise68(KeyValuePair<int, string> taskData) : base(taskData) { }
        delegate int SolutionType(int n, int m);

        public override bool Solution()
        {
            string errorMessage = "Введено некорректное число. Введите другое: ";
            Console.Write("Введите первое число (N): ");
            int n = InputNumbers.GetObjectFromConsole<int>(errorMessage);
            Console.Write("Введите первое число (M): ");
            int m = InputNumbers.GetObjectFromConsole<int>(errorMessage);

            SolutionType checkedAckermann = CheckSolution();
            Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {checkedAckermann(n, m)}");
            return false;
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

        private SolutionType CheckSolution()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите способ вычисления:");
            int answer = Lessons.StartMenu.GetMenu(new string[] { "Рекурсивный.", "Итерационно-рекурсивный." }, false, false);
            return answer == 1 ? AckermannRec : AckermannItRec;
        }


    }
}