using System;

namespace proga
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = new string[] { "Введите A", "Введите B", "+", "-", "*", "/", "End", };

            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            while (true)
            {
               
            }
        }

        private static void DrawMenu(string[] items, int row, int col, int index, int result)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
