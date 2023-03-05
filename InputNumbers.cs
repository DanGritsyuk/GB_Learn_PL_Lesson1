using System.ComponentModel;

namespace Lessons
{
    public static class InputNumbers
    {
        public static T[] GetArrayFromConsole<T>() =>
            Console.ReadLine()!.Split(' ', '.', ',', ';').Where(i => TryParseObject<T>(i, out _)).Select(ParseObject<T>).ToArray<T>();

        public static T[,] GetTwoDimensionalArrayFromConsole<T>()
        {
            Console.WriteLine("Введите длину массива: ");
            int col = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:");
            Console.WriteLine("Введите высоту массива: ");
            int row = InputNumbers.GetNumberFromConsole(1, int.MaxValue, "Некорректное число. Повторите попытку:");
            var array = new T[row, col];

            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Введите {col} чисел для строки {i + 1}:");
                T[] rowArrayString;

                while (true)
                {
                    rowArrayString = GetArrayFromConsole<T>();
                    if (rowArrayString.Length == col)
                        break;
                    else if (rowArrayString.Length > col)
                        Console.WriteLine($"Введено больше {col} чисел. Повторите попытку:");
                    else if (rowArrayString.Length < col)
                        Console.WriteLine($"Введено меньше {col} чисел. Повторите попытку:");
                }

                for (int j = 0; j < rowArrayString.Length; j++)
                {
                    array[i, j] = rowArrayString[j];
                }
            }
            return array;
        }

        public static T GetObjectFromConsole<T>(string errorMessage)
        {
            while (true)
            {
                try { return ParseObject<T>(Console.ReadLine()!); }
                catch { Console.Write($"{errorMessage} Повторите попытку: "); }
            }
        }

        public static int GetNumberFromConsole(int[] range, bool isInRange, string errorMessage)
        {
            int n = 0;
            while (true)
            {
                n = InputNumbers.GetObjectFromConsole<int>("Введено некоректное число.");

                if (isInRange)
                {
                    foreach (var x in range)
                    {
                        if (x == n) return n;
                    }
                    Console.WriteLine(errorMessage);

                }
                else
                {
                    bool notInRange = true;
                    foreach (var x in range)
                    {
                        if (x == n)
                        {
                            Console.WriteLine(errorMessage);
                            notInRange = false;
                            break;
                        }
                    }
                    if (notInRange) return n;
                }
            }
        }

        public static int GetNumberFromConsole(int first, int last, string errorMessage)
        {
            if (first > last) throw new ArgumentException();
            int n = 0;
            Func<bool> tryGetThreedigitFromConsole = () => // Функция для вызова одного и того же кода в нескольких местах в этом методе 
            {
                n = InputNumbers.GetObjectFromConsole<int>("Введено некоректное число.");
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
        private static bool TryParseObject<T>(string strObjectInfo, out T result)
        {
            result = default!;
            bool isCorrectOnject = true;
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                    result = (T)converter.ConvertFromString(strObjectInfo)!;
            }
            catch { isCorrectOnject = false; }

            return isCorrectOnject;
        }

        private static T ParseObject<T>(string str)
        {
            T result;
            return TryParseObject(str, out result) ? result : throw new ArgumentException();
        }
    }
}