namespace Lesson1
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
    }
}