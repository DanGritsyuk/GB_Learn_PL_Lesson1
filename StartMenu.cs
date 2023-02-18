using System.Text;

namespace Lessons
{
    public static class StartMenu
    {
        public static KeyValuePair<int, string> GetMenu(Dictionary<int, string> menuItems, bool showHelpControl = false)
        {
            int taskIndex = 0, taskKey = 0;
            string taskText = "";

            var tasksArrayKeys = new int[menuItems.Count];
            var tasksArrayValues = new string[tasksArrayKeys.Length];
            foreach (var taskData in menuItems)
            {
                tasksArrayKeys[taskIndex] = taskData.Key;
                tasksArrayValues[taskIndex] = $"Задача{(taskData.Key < 10 ? "  " : " ")}{taskData.Key}: {taskData.Value}";

                taskIndex++;
            }
            taskIndex = Lessons.StartMenu.GetMenu(tasksArrayValues, showHelpControl);
            if (taskIndex > 0)
            {
                taskIndex--;
                taskKey = tasksArrayKeys[taskIndex];
                taskText = menuItems[taskKey];
            }

            return new KeyValuePair<int, string>(taskKey, taskText);
        }

        public static int GetMenu(string[] menuLines, bool showHelpControl = false)
        {

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuLines, row, col, index, showHelpControl);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuLines.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        return index + 1;
                    case ConsoleKey.Escape:
                        return 0;
                }
            }
        }
        private static void DrawMenu(string[] menuLines, int row, int col, int index, bool showHelpControl)
        {
            var largerLine = menuLines[0].Length;
            Console.SetCursorPosition(col, row);
            for (int i = 0; i <= menuLines.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (i == menuLines.Length)
                {
                    if (showHelpControl)
                    {
                        WriteEndLine(largerLine);
                        Console.Write("↑ ↓ - перемещаться между строками. ");
                        Console.Write("Enter - выбрать задачу. ");
                        Console.WriteLine("Для выхода нажмите Esc.");
                    }
                }
                else
                {
                    if (largerLine < menuLines[i].Length)
                        largerLine = menuLines[i].Length;
                    Console.WriteLine(menuLines[i]);
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        private static void WriteEndLine(int lineLength)
        {
            StringBuilder endLine = new StringBuilder("");

            for (int i = 1; i < lineLength; i++)
            {
                endLine.Append("=");
            }

            Console.WriteLine(endLine.ToString());
        }
    }
}