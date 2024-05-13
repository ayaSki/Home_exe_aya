using _2048Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            b.StartGame();
            User.ConsoleGame consoleGame = new User.ConsoleGame();
            consoleGame.Board = b;
            consoleGame.ShowBoard();
            Console.ReadLine();

        }
    }
}
