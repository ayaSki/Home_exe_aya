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
            Game game = new Game();
            game.Board.StartGame();
            while (game.Status == Enums.GameStatus.Idle)
            {
                ShowBoard(game.Board);
                game.Move(GetDirection());
            }
        }
    }
}
