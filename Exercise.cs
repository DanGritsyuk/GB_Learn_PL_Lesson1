namespace Lessons
{
    public abstract class Exercise
    {
        private string _taskNum = "б/н";

        public Exercise(int taskNum) => _taskNum = taskNum.ToString();

        public abstract void Body();

        public void Start()
        {
            var done = false;
            while (!done)
            {
                Console.Clear();
                Console.WriteLine($"Выбрана задача {_taskNum}.");
                Console.WriteLine("==========================================");
                Body();
                done = End();
            }
        }
        protected bool End()
        {
            Console.Write("Выйти в главное меню? (Y/N): ");
            char answer;
            while (!char.TryParse(Console.ReadLine(), out answer) || !(answer == 'Y' || answer == 'y' || answer == 'N' || answer == 'n')) // Если в консоль ввели не символ, либо символ не равный Y\y и N/n то повторить ввод.
                Console.Write("Ответ некорректен. Введите (Y/N): ");

            return answer == 'Y' || answer == 'y';
        }
    }
}