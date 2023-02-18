namespace Lessons
{
    public static class InputNumbers
    {
        public static int GetNumberFromConsole()
        {
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.Write("Введено некоректное число. Повторите попытку: ");
            return number;
        }


        public static int GetNumberFromConsole(int first, int last, string errorMessage)
        {
            if (first > last) throw new ArgumentException();
            int n = 0;
            Func<bool> tryGetThreedigitFromConsole = () => // Функция для вызова одного и того же кода в нескольких местах в этом методе 
            {
                n = InputNumbers.GetNumberFromConsole();
                return n >= first && n <= last;
            };

            bool nCorrect = tryGetThreedigitFromConsole();
            while (!nCorrect)
            {
                Console.Write(errorMessage);
                nCorrect = tryGetThreedigitFromConsole();
            }
            return n;
        }
    }
}