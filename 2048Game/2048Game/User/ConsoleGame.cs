using _2048Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.User
{
    public class ConsoleGame : Logic.logicalFunctions
    {
        public void Print(string txt)
        {
            Console.WriteLine(txt);
        }
        public void ShowBoard(Board board)
        {
            Console.WriteLine(constants.Row);
            for(int i = 0; i < constants.BoardSize; i++)
            {
                Console.Write("|");
                for (int j = 0; j < constants.BoardSize; j++)
                {
                    Console.Write($"{NumberToStr(board.Data[i, j])}|");
                }
                Console.Write("\n");
                Console.WriteLine(constants.Row);
                Console.Write("\n");
            }
        }

        public Enums.Direction GetConsoleKey()
        {
            var key = Console.ReadKey(true).Key;
            do
            {
                if (key == ConsoleKey.RightArrow)
                {
                    return Enums.Direction.Right;
                }
                if (key == ConsoleKey.LeftArrow)
                {
                    return Enums.Direction.Left;
                }
                if (key == ConsoleKey.DownArrow)
                {
                    return Enums.Direction.Down;
                }
                if (key == ConsoleKey.UpArrow)
                {
                    return Enums.Direction.Up;
                }
                if (key == ConsoleKey.Enter)
                {
                    return Enums.Direction.Enter;
                }
            } while (key != ConsoleKey.Enter || key != ConsoleKey.UpArrow ||
            key != ConsoleKey.DownArrow || key != ConsoleKey.LeftArrow ||
            key != ConsoleKey.RightArrow);
            return Enums.Direction.error;
        }
    }
}
