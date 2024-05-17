using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    public class constants
    {
        public const int BoardSize = 4;
        public const int StartPos = 2;
        public const int NumberOfCells = 16;
        public const string Space = " ";
        public const string Row = "____________________";
        public const string Menu = "WELCOME to... 2048\n" +
            "Use your arrow keys to move the tiles.\n" +
            "Tiles with the same number merge into one when they touch.\n" +
            "Add them up to reach 2048!\n" +
            "To start the game press Enter!";
        public const string LoseMessage = "You Lose!";
        public const string WinMessage = "You Win!";
        public const string PointsMessage = "Your points: ";
    }
}
