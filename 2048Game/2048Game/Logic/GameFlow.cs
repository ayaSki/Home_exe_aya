using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    public class GameFlow : User.ConsoleGame
    {
        public GameFlow()
        {
            Print(constants.Menu);
            while(GetConsoleKey() != Enums.Direction.Enter)
            {
                continue;
            }
            Game game = new Game();
            game.Board.StartGame();
            while (game.Status == Enums.GameStatus.Idle)
            {
                Console.Clear();
                Print($"{constants.PointsMessage} {game.Points}");
                ShowBoard(game.Board);
                game.Move(GetConsoleKey());
                if(game.Status == Enums.GameStatus.Lose)
                {
                    Print(constants.LoseMessage);
                }
                if (game.Status == Enums.GameStatus.Win)
                {
                    Print(constants.WinMessage);
                }
            }
            int m = int.Parse(Console.ReadLine());
        }
    }
}
