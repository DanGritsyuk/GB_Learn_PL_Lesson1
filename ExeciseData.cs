using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public class ExeciseData
    {
        public ExeciseData()
        {
            _dataList = LoadExerciseOptions();
            SetParameters();
        }
        public ExeciseData(Dictionary<int, string> data)
        {
            _dataList = data;
            SetParameters();
        }

        private Dictionary<int, string> _dataList;
        private int _maxIndex;
        private int _length;
        public Dictionary<int, string> DataList
        {
            get { return _dataList; }
        }
        public int MaxIndex
        {
            get { return _maxIndex; }
        }
        public int Length
        {
            get { return _length; }
        }

        public Tuple<int[], string[]> GetTextToConsole()
        {
            int CountNumbers(int num)
            {
                int i = 0;
                while (num > 0)
                {
                    i++;
                    num /= 10;
                }
                return i;
            }

            int taskIndex = 0;
            var tasksArrayKeys = new int[this.Length];
            var tasksArrayValues = new string[tasksArrayKeys.Length];
            foreach (var taskData in _dataList)
            {
                var spaceCount = new StringBuilder(" ");
                for (int i = CountNumbers(MaxIndex) - CountNumbers(taskData.Key); i > 0; i--)
                    spaceCount.Append(' ');

                tasksArrayKeys[taskIndex] = taskData.Key;
                tasksArrayValues[taskIndex] = $"Задача{spaceCount.ToString()}{taskData.Key}: {taskData.Value}";

                taskIndex++;
            }
            return new Tuple<int[], string[]>(tasksArrayKeys, tasksArrayValues);
        }

        public override string ToString()
        {
            var sb = new StringBuilder("СОХРАНЕНЫЕ ДАННЫЕ:");

            Tuple<int[], string[]> dataForPrint = GetTextToConsole();
            foreach (var item in dataForPrint.Item2)
            {
                sb.Append("\n");
                sb.Append(item);
            }

            return sb.ToString();
        }

        private static Dictionary<int, string> LoadExerciseOptions()
        {
            var fileName = "Data/ExercisesOption.xml";
            var saveLoad = new SaveLoadFile();
            var dataFromFile = new Dictionary<int, string>();

            try
            {
                var fileInfo = saveLoad.DeSerializeObject<List<KeyValuePair<int, string>>>(fileName);

                dataFromFile = fileInfo.ToDictionary(item => item.Key, item => item.Value);
            }
            catch
            {
                dataFromFile.Add(2, "Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
                dataFromFile.Add(4, "Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
                dataFromFile.Add(6, "Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
                dataFromFile.Add(8, "Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
                dataFromFile.Add(10, "Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
                dataFromFile.Add(13, "Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
                dataFromFile.Add(15, "Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
                dataFromFile.Add(19, "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
                dataFromFile.Add(21, "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
                dataFromFile.Add(23, "Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

                if (!Directory.Exists("Data"))
                    Directory.CreateDirectory("Data");

                SaveToXMLfile(dataFromFile, saveLoad, fileName);
            }
            return dataFromFile;
        }
        private static void SaveToXMLfile(Dictionary<int, string> tasksData, SaveLoadFile saveLoad, string fileName)
        {
            var fileInfo = new List<string[]>();

            int i = 0;
            foreach (var taskData in tasksData)
            {
                fileInfo.Add(new string[] { taskData.Key.ToString(), taskData.Value.ToString() });
                i++;
            }

            saveLoad.SerializeObject(fileInfo, fileName);
        }

        private void SetParameters()
        {
            _maxIndex = _dataList.Keys.Max();
            _length = _dataList.Count();
        }
    }
}