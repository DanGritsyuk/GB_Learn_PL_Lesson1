using System.Text;

namespace Lessons
{
    public static class StartMenu
    {
        public static void GetMenu(string[] itemsForMenu)
        {
            Console.Clear();
            if (itemsForMenu == null) throw new ArgumentNullException();

            string[] menuLines = new string[itemsForMenu.Length + 1];
            menuLines[0] = "Выход";

            for (int i = 0; i < itemsForMenu.Length; i++)
                menuLines[i + 1] = itemsForMenu[i];

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 1;
            while (true)
            {
                DrawMenu(menuLines, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuLines.Length)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 1)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        if (index == menuLines.Length)
                            index = 0;
                        switch (index)
                        {
                            case 0:
                                Console.WriteLine("Выбран выход из приложения");
                                return;
                            default:
                                Console.WriteLine($"Выбран пункт {menuLines[index]}");
                                break;
                        }
                        break;
                }
            }
        }
        private static void DrawMenu(string[] menuLines, int row, int col, int index)
        {
            var largerLine = menuLines[0].Length;
            Console.SetCursorPosition(col, row);
            for (int i = 1; i <= menuLines.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (i == menuLines.Length)
                {
                    WriteEndLine(largerLine);
                    Console.WriteLine(menuLines[0]);
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
            StringBuilder sb = new StringBuilder("");

            for (int i = 1; i < lineLength; i++)
            {
                sb.Append("=");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}