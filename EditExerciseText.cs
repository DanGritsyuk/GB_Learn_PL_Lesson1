namespace Lessons
{
    public static class EditExerciseText
    {
        public static void StratGetEditor()
        {

        }
        public static Dictionary<int, string> GetExerciseOptions()
        {
            var tasksData = new Dictionary<int, string>();
            var fileName = "Data/ExercisesOption.xml";
            var saveLoad = new SaveLoadFile();

            try
            {
                var fileInfo = saveLoad.DeSerializeObject<List<KeyValuePair<int, string>>>(fileName);

                tasksData = fileInfo.ToDictionary(item => item.Key, item => item.Value);
            }
            catch
            {
                tasksData.Add(2, "Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
                tasksData.Add(4, "Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
                tasksData.Add(6, "Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
                tasksData.Add(8, "Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
                tasksData.Add(10, "Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
                tasksData.Add(13, "Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
                tasksData.Add(15, "Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
                tasksData.Add(19, "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
                tasksData.Add(21, "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
                tasksData.Add(23, "Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

                SaveToXMLfile(tasksData, saveLoad, fileName);
            }
            return tasksData;
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
    }
}