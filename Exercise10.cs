namespace Lesson1
{
    public class Exercise10 : Exercise
    {
        public Exercise10(int taskNum) : base(taskNum) { }

        public override void Body()
        {
            Console.Write("Введите число (n): ");
            int n = GetThreedigitNumberFromConsole();

            Console.WriteLine($"Вторая цифра числа {n} это {n / 10 % 10}");
        }

        private int GetThreedigitNumberFromConsole()
        {
            int n = 0;
            Func<bool> tryGetThreedigitFromConsole = () => // Безывмянная функция для вызова одного и того же кода в нескольких местах в этом методе 
            {
                n = InputNumbers.GetNumberFromConsole();
                return n > 99 && n < 1000;
            };

            bool nCorrect = tryGetThreedigitFromConsole();
            while (!nCorrect)
            {
                Console.Write("Веедено не трехзначное число. Введите корректное: ");
                nCorrect = tryGetThreedigitFromConsole();
            }
            return n;
        }
    }
}