using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    internal class Enums
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public enum GameStatus
        {
            Win,
            Lose,
            Idle
        }

    }
}
