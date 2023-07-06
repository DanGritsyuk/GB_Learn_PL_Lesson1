namespace Lessons
{
    public abstract class Exercise
    {
        public Exercise(int taskNum, string description)
        {
            _taskNum = taskNum;
            _description = description;
        }
        public Exercise(KeyValuePair<int, string> taskData)
        {
            _taskNum = taskData.Key;
            _description = taskData.Value;
        }

        private int _taskNum;
        private string _description;
        private string _borderLine = "==========================================";

        public abstract bool Solution();

        public void Start()
        {
            var done = false;
            while (!done)
            {
                DrawHeader();
                try
                {
                    done = Solution();
                }
                catch (Exception e)
                {
                    DrawHeader();
                    Console.WriteLine(e);
                }

                if (!done)
                {
                    DrawFooter();
                    done = End();
                }
            }
        }

        private bool End()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите слудующий шаг:");
            int answer = Lessons.StartMenu.GetMenu(new string[] { "Выход в главное меню.", "Повторить ввод." });
            return answer < 2;
        }

        private void DrawHeader()
        {
            Console.Clear();
            Console.WriteLine($"Выбрана задача {_taskNum.ToString()}.\n {_description}");
            Console.WriteLine(_borderLine);
        }

        private void DrawFooter()
        {
            Console.WriteLine($"\n\n {_borderLine}");
        }
    }
}