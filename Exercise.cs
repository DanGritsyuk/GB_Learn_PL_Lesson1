namespace Lessons
{
    public abstract class Exercise
    {
        public Exercise(int taskNum, string description)
        {
            _taskNum = taskNum;
            _description = description;
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
            /* Console.Write("Выйти в главное меню? (Y/N): ");
             char answer;
             while (!char.TryParse(Console.ReadLine(), out answer) || !(answer == 'Y' || answer == 'y' || answer == 'N' || answer == 'n')) // Если в консоль ввели не символ, либо символ не равный Y\y и N/n то повторить ввод.
             Console.Write("Ответ некорректен. Введите (Y/N): ");

             return answer == 'Y' || answer == 'y';*/

            Console.WriteLine();
            Console.WriteLine("Выйти в главное меню?");
            int answer = Lessons.StartMenu.GetMenu(new string[] { "Да", "Нет" });
            return answer < 2;
        }
    }
}