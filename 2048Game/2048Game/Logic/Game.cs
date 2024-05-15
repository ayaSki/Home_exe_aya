using _2048Game.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    public class Game
    {
        public Board Board { get; protected set; }
        public Enums.GameStatus Status { get; protected set; }
        public int Points { get; protected set; }

        public Game()
        {
            Board = new Board();
            Status = Enums.GameStatus.Idle;
            Points = 0;
        }

        public void Move(Enums.Direction direction)
        {
            if(Status == Enums.GameStatus.Lose || Status == Enums.GameStatus.Win || direction == Enums.Direction.error)
            {
                return;
            }
            Points += Board.Move(direction);
        }

        public bool FullBoard()
        {
            return Board.NumberOfFullSpots == constants.NumberOfCells;
        }

        public bool Contains2048()
        {
            return Board.ToString().Contains("2048");
        }
    }
}
