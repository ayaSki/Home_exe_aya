using _2048Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.User
{
    public class ConsoleGame
    {
        public void ShowBoard(Board board)
        {
            Console.WriteLine(constants.Row);
            for(int i = 0; i < constants.BoardSize; i++)
            {
                Console.Write("|");
                for (int j = 0; j < constants.BoardSize; j++)
                {
                    Console.Write(NumberToStr(board.Data[i, j]) + "|");
                }
                Console.Write("\n");
                Console.WriteLine(constants.Row);
                Console.Write("\n");
            }
        }

        public Enums.Direction GetDirection()
        {
            var key = Console.ReadKey(true).Key;
            if(key == ConsoleKey.RightArrow)
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
            return Enums.Direction.error;
        }

        public string NumberToStr(int number)
        {
            if(number == 0)
            {
                return DuplicateSpace(4);
            }
            if(NumberLen(number) == 1)
            {
                return $"{number.ToString()}{DuplicateSpace(3)}";
            }
            if (NumberLen(number) == 2)
            {
                return $"{number.ToString()}{DuplicateSpace(2)}";
            }
            if (NumberLen(number) == 3)
            {
                return $"{number.ToString()}{DuplicateSpace(1)}";
            }
            return number.ToString();
        }

        private int NumberLen(int number)
        {
            return (number > 0) ? 1 + NumberLen(number / 10) : 0;
        }

        private string DuplicateSpace(int number)
        {
            string longSpace = "";
            for(int i = 0; i < number; i++)
            {
                longSpace += constants.Space;
            }
            return longSpace;
        }
    }
}
