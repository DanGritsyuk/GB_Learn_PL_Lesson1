using System.Text;

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
        private const string FileName = "Data/ExercisesOption.xml";
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

        public void AddNewExercise(int index, string text)
        {
            if (!_dataList.ContainsKey(index))
                _dataList.Add(index, text);
        }

        public void UpdateExercise(int key, string text) => _dataList[key] = text;
        public void RemoveExercise(int key) => _dataList.Remove(key);

        public Tuple<int[], string[]> GetTextForConsole()
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

        public void SaveToFile() => SaveToXMLfile(this.DataList, new SaveLoadFile());

        public override string ToString()
        {
            var sb = new StringBuilder("СОХРАНЕНЫЕ ДАННЫЕ:");

            Tuple<int[], string[]> dataForPrint = GetTextForConsole();
            foreach (var item in dataForPrint.Item2)
            {
                sb.Append("\n");
                sb.Append(item);
            }

            return sb.ToString();
        }

        private static Dictionary<int, string> LoadExerciseOptions()
        {
            var saveLoad = new SaveLoadFile();
            var dataFromFile = new Dictionary<int, string>();

            try
            {
                var fileInfo = saveLoad.DeSerializeObject<List<string[]>>(FileName);

                dataFromFile = fileInfo.ToDictionary(item => int.Parse(item[0]), item => item[1]);
            }
            catch
            {
                dataFromFile.Add(99, "Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");

                if (!Directory.Exists("Data"))
                    Directory.CreateDirectory("Data");

                SaveToXMLfile(dataFromFile, saveLoad);
            }
            return dataFromFile;
        }
        private static void SaveToXMLfile(Dictionary<int, string> tasksData, SaveLoadFile saveLoad)
        {
            var fileInfo = new List<string[]>();

            foreach (var taskData in tasksData)
                fileInfo.Add(new string[] { taskData.Key.ToString(), taskData.Value.ToString() });

            saveLoad.SerializeObject(fileInfo, FileName);
        }

        private void SetParameters()
        {
            _maxIndex = _dataList.Keys.Max();
            _length = _dataList.Count();
        }
    }
}