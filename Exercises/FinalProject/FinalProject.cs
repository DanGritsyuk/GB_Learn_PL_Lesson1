// Итоговый проект. Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

namespace Lessons
{
    public class FinalProject : Exercise
    {
        public FinalProject(KeyValuePair<int, string> taskData) : base(taskData) { }

        public override bool Solution()
        {
            Console.Write("Введите строку: ");
            var strArray = InputNumbers.GetArrayFromConsole<string>();
            PrintObjects.PrintArray<string>(GetThreeCharStringArray(strArray));
            return false;
        }

        private string[] GetThreeCharStringArray(string[] sourceArray)
        {
            string[] newArray = new string[GetThreeCharStringCount(sourceArray)];

            int index = 0, maxLength = 3;

            for (int i = 0; i < sourceArray.Length; i++)
                if (sourceArray[i].Length <= maxLength)
                {
                    newArray[index] = sourceArray[i];
                    index++;
                }

            return newArray;
        }

        private int GetThreeCharStringCount(string[] array)
        {
            int count = 0, maxLength = 3;

            for (int i = 0; i < array.Length; i++)
                if (array[i].Length <= maxLength)
                {
                    count++;
                }
            return count;
        }
    }
}