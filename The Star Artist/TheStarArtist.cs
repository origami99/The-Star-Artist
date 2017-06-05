using System;

namespace MyFirstConsoleGame
{
    class TheStarArtist
    {
        /// <summary>
        /// ATTENTION !!! This is my first console game and it has super bad poor quality code !!! ATTENTION
        /// </summary>
        static void Main()
        {
            Console.Title = "The Star Artist";

            int count = 1;

            int h = Console.LargestWindowHeight - 10;
            int w = Console.LargestWindowWidth - 20;
            Console.WindowHeight = h;
            Console.WindowWidth = w;

            string wallTop = new string('=', w);

            Console.SetCursorPosition(w - 33, h - 1);
            Console.WriteLine("Created by: Nikolay Liubomirov");

            Console.SetCursorPosition(w / 2 - 8, 1);
            Console.Write("╔═╗┌┬┐┌─┐┬─┐┌┬┐");
            Console.SetCursorPosition(w / 2 - 8, 2);
            Console.Write("╚═╗ │ ├─┤├┬┘ │ ");
            Console.SetCursorPosition(w / 2 - 8, 3);
            Console.Write("╚═╝ ┴ ┴ ┴┴└─ ┴ ");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine(wallTop);
            Console.SetCursorPosition(0, h - 3);
            Console.WriteLine(wallTop);

            Console.SetCursorPosition(w / 2 - 1, 5);

            while (true)
            {
                ConsoleKeyInfo button = Console.ReadKey(true);

                Random r = new Random();
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);

                if (button.Key == ConsoleKey.RightArrow || button.Key == ConsoleKey.D)
                {
                    if (Console.CursorLeft >= Console.LargestWindowWidth - 21)
                    {
                        Console.CursorLeft = 1;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                else if (button.Key == ConsoleKey.LeftArrow || button.Key == ConsoleKey.A)
                {
                    if (Console.CursorLeft <= 0)
                    {
                        Console.CursorLeft = Console.LargestWindowWidth - 22;
                    }
                    else
                    {
                        Console.Write("*");
                        Console.CursorLeft -= 2;
                    }
                }
                else if (button.Key == ConsoleKey.UpArrow || button.Key == ConsoleKey.W)
                {
                    if (Console.CursorTop <= 4)
                    {
                        Console.CursorTop = Console.LargestWindowHeight - 14;
                    }
                    else
                    {
                        Console.Write("*");
                        Console.CursorLeft -= 1;
                        Console.CursorTop -= 1;
                    }
                }
                else if (button.Key == ConsoleKey.DownArrow || button.Key == ConsoleKey.S)
                {
                    if (Console.CursorTop >= Console.LargestWindowHeight - 13)
                    {
                        Console.CursorTop = 5;
                    }
                    else
                    {
                        Console.Write("*");
                        Console.CursorLeft -= 1;
                        Console.CursorTop += 1;
                    }
                }

                else if (button.Key == ConsoleKey.R)
                {
                    count++;

                    Console.Clear();

                    Console.SetCursorPosition(w - 33, h - 1);
                    Console.WriteLine("Created by: Nikolay Liubomirov");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(wallTop);
                    Console.SetCursorPosition(0, h - 3);
                    Console.WriteLine(wallTop);

                    if (count % 3 == 0)
                    {
                        Console.SetCursorPosition(w - 26, 1);
                        Console.Write("╔═╗┌┬┐┌─┐┬─┐┌┬┐");
                        Console.SetCursorPosition(w - 26, 2);
                        Console.Write("╚═╗ │ ├─┤├┬┘ │ ");
                        Console.SetCursorPosition(w - 26, 3);
                        Console.Write("╚═╝ ┴ ┴ ┴┴└─ ┴ ");

                        Console.SetCursorPosition(w - 19, 5);
                    }
                    else if (count % 2 == 0)
                    {
                        Console.SetCursorPosition(10, 1);
                        Console.Write("╔═╗┌┬┐┌─┐┬─┐┌┬┐");
                        Console.SetCursorPosition(10, 2);
                        Console.Write("╚═╗ │ ├─┤├┬┘ │ ");
                        Console.SetCursorPosition(10, 3);
                        Console.Write("╚═╝ ┴ ┴ ┴┴└─ ┴ ");

                        Console.SetCursorPosition(17, 5);
                    }
                    else
                    {
                        Console.SetCursorPosition(w / 2 - 8, 1);
                        Console.Write("╔═╗┌┬┐┌─┐┬─┐┌┬┐");
                        Console.SetCursorPosition(w / 2 - 8, 2);
                        Console.Write("╚═╗ │ ├─┤├┬┘ │ ");
                        Console.SetCursorPosition(w / 2 - 8, 3);
                        Console.Write("╚═╝ ┴ ┴ ┴┴└─ ┴ ");

                        Console.SetCursorPosition(w / 2 - 1, 5);
                    }
                }
                else if (button.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}