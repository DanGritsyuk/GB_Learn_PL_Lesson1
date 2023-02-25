// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

namespace Lessons
{
    public class Exercise41 : Exercise
    {
        public Exercise41(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override void Body()
        {
            int countPos = 0;
            string errorMessage = "Некорректное число. Повторите попытку:";
            Console.Write("Введите количество чисел (M): ");
            var array = new int[InputNumbers.GetNumberFromConsole(1, int.MaxValue, errorMessage)];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                array[i] = InputNumbers.GetNumberFromConsole<int>(errorMessage);
                countPos += array[i] > 0 ? 1 : 0;
            }
            Console.WriteLine();
            Console.WriteLine($"Было введено {countPos} чисел, которые больше 0");
        }
    }
}