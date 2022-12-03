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

            int index = 0;
            int result = 0;
            int A = 0;
            int B = 0;

            while (true)
            {
                DrawMenu(menuItems, row, col, index, result);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 0:
                                Console.WriteLine("Введите A:");
                                A = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(A);
                                break;

                            case 1:
                                Console.WriteLine("Введите B:");
                                A = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(B);
                                break;

                            case 2:
                                result = A + B;
                                Console.WriteLine(result);
                                break;

                            case 3:
                                result = A - B;
                                Console.WriteLine(result);
                                break;

                            case 4:
                                result = A * B;
                                Console.WriteLine(result);
                                break;

                            case 5:
                                result = A / B;
                                Console.WriteLine(result);
                                break;
                        }

                        break;
                }
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
