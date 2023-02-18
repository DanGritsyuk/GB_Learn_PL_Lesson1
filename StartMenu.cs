using System.Text;

namespace Lessons
{
    public static class StartMenu
    {
        public static int GetMenu(string[] menuLines)
        {

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuLines, row, col, index);
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
        private static void DrawMenu(string[] menuLines, int row, int col, int index)
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
                    WriteEndLine(largerLine);
                    Console.WriteLine("Для выхода нажмите Esc");
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