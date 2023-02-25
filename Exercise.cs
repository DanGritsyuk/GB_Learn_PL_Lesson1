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

        public abstract void Body();

        public void Start()
        {
            var done = false;
            while (!done)
            {
                Console.Clear();
                Console.WriteLine($"Выбрана задача {_taskNum.ToString()}.\n {_description}");
                Console.WriteLine("==========================================");
                Body();
                done = End();
            }
        }
        protected bool End()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите слудующий шаг:");
            int answer = Lessons.StartMenu.GetMenu(new string[] { "Выход в главное меню.", "Повторить ввод." });
            return answer < 2;
        }
    }
}