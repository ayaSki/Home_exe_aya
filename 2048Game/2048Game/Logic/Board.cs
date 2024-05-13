using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    public class Board
    {
        public int[,] Data { get; protected set; }
        public int NumberOfFullSpots {  get; set; }

        public Board()
        {
            Data = new int[constants.BoardSize,constants.BoardSize];
            NumberOfFullSpots = 0;
        }

        public void StartGame()
        {
            while(NumberOfFullSpots != 2)
            {
                int[] index = RandomCell();
                if(EmptyCell(index))
                {
                    Data[index[0], index[1]] = RandomAddNumber();
                    NumberOfFullSpots++;
                }
            }
        }

        public int Move(Enums.Direction direction)
        {
            switch (direction)
            {
                case Enums.Direction.Up:
                    break;
            }

        }

        private int[] RandomCell()
        {
            Random row = new Random();
            Random queue = new Random();
            int[] index = { row.Next(1, constants.BoardSize), queue.Next(1, constants.BoardSize) };
            return index;
        }

        private bool EmptyCell(int[] index)
        {
            return Data[index[0], index[1]] == 0;    
        }

        private int RandomAddNumber()
        {
            Random rnd = new Random();
            int numberToAdd = 0;
            while(numberToAdd != 2 || numberToAdd != 4)
            {
                numberToAdd = rnd.Next(2, 4);
            }
            return numberToAdd;
        }


    }
}
