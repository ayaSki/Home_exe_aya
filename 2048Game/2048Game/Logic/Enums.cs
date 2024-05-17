using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    public class Enums
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down,
            Enter,
            error
        }

        public enum GameStatus
        {
            Win,
            Lose,
            Idle
        }

    }
}
