namespace Lessons
{
    public static class EditExerciseText
    {
        public static bool TryStratGetEditor()
        {
            var isStarted = true;
            try { StratGetEditor(); }
            catch { isStarted = false; }
            return isStarted;
        }
        public static void StratGetEditor()
        {
            var menuItems = new string[] { "Добавить задачу", "Редактировать задачу", "Удалить задачу" };

            bool doneEdit = false;
            while (!doneEdit)
            {
                var exerciseData = new ExerciseData();

                Console.Clear();
                Console.WriteLine(exerciseData.ToString());
                Console.WriteLine();
                var selectedEditMenuItem = StartMenu.GetMenu(menuItems, true);

                switch (selectedEditMenuItem)
                {
                    case 0: doneEdit = true; break;
                    case 1: AddNewExercise(exerciseData); break;
                    case 2: EditExercise(exerciseData); break;
                    case 3: DeleteExercise(exerciseData); break;
                }
            }
        }
        private static void AddNewExercise(ExerciseData exerciseData)
        {
            if (exerciseData == null) throw new ArgumentException();

            string exerciseText = "";
            int exerciseNumber = 0;

            exerciseNumber = WriteEditingMenu(out exerciseText, exerciseData.DataList.Keys.ToArray(), false, "Такая задача уже существует. Введите другой номер:");
            if (IsConfirm())
            {
                exerciseData.AddNewExercise(exerciseNumber, exerciseText);
                exerciseData.SaveToFile();
            }
        }

        private static void EditExercise(ExerciseData execiseData)
        {
            if (execiseData == null) throw new ArgumentException();

            string exerciseText = "";
            int exerciseNumber = 0;

            exerciseNumber = WriteEditingMenu(out exerciseText, execiseData.DataList.Keys.ToArray(), true, "Такой задачи нет. Введите номер существующей");
            if (IsConfirm())
            {
                execiseData.UpdateExercise(exerciseNumber, exerciseText);
                execiseData.SaveToFile();
            }
        }

        private static void DeleteExercise(ExerciseData execiseData)
        {
            if (execiseData == null) throw new ArgumentException();

            Console.Clear();
            Console.WriteLine("Введите номер задачи:");
            int exerciseNumber = InputNumbers.GetNumberFromConsole(execiseData.DataList.Keys.ToArray(), true, "Такой задачи нет. Введите номер существующей");
            if (IsConfirm())
            {
                execiseData.RemoveExercise(exerciseNumber);
                execiseData.SaveToFile();
            }
        }

        private static int WriteEditingMenu(out string exerciseText, int[] range, bool isInRange, string errorMessage)
        {
            Console.Clear();
            Console.WriteLine("Введите номер задачи:");
            int exerciseNumber = InputNumbers.GetNumberFromConsole(range, isInRange, errorMessage);
            Console.WriteLine();
            Console.WriteLine("Введите условие задачи:");
            exerciseText = Console.ReadLine()!;
            return exerciseNumber;
        }

        private static bool IsConfirm()
        {
            Console.WriteLine();
            Console.WriteLine("Подтвердите действие");
            int answer = Lessons.StartMenu.GetMenu(new string[] { "Подтвердить", "Отмена" });
            return answer == 1;
        }
    }
}