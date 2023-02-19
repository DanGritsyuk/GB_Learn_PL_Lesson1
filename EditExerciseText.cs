namespace Lessons
{
    public static class EditExerciseText
    {
        public static void StratGetEditor()
        {
            var execiseData = new ExeciseData();
            var menuItems = new string[] { "Добавить задачу", "Редактировать задачу", "Удалить задачу" };

            bool doneEdit = false;
            while (!doneEdit)
            {
                Console.Clear();
                Console.WriteLine(execiseData.ToString());
                Console.WriteLine();
                var selectedEditMenuItem = StartMenu.GetMenu(menuItems, true);

                switch (selectedEditMenuItem)
                {
                    case 0: doneEdit = true; break;
                    case 1: AddNewExercise(); break;
                    case 2: DeleteExercise(); break;
                    case 3: DeleteExercise(); break;
                }
            }
        }
        // Все еще в разраотке.
        private static void AddNewExercise()
        {
            Console.Clear();
            Console.WriteLine("Скоро реализую");
            Console.ReadKey();
        }

        private static void EditExercise()
        {
            AddNewExercise();
        }

        private static void DeleteExercise()
        {
            AddNewExercise();
        }
    }
}