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
            int[] xy = new int[2];
            switch (direction)
            {
                case Enums.Direction.Up:
                    xy[0] = 1;
                    xy[1] = 0;
                    break;
                case Enums.Direction.Down:
                    xy[0] = -1;
                    xy[1] = 0;
                    break;
                case Enums.Direction.Left:
                    xy[0] = 0;
                    xy[1] = -1;
                    break;
                case Enums.Direction.Right:
                    xy[0] = 0;
                    xy[1] = 1;
                    break;
                defult:
                    break;
            }
            return ChangeCellsByXY(xy[0], xy[1]);
        }
        private int ChangeCellsByXY(int x, int y)
        {
            int iValue = 0;
            int jValue = 0;
            if(x == 0)
            {
                iValue = 0;
                jValue = 1;
            }
            for (int i = 0; i < constants.BoardSize; i++)
            {
                for(int j = 0; j < constants.BoardSize; j++)
                {
                    
                }
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
            while(numberToAdd != 2 && numberToAdd != 4)
            {
                numberToAdd = rnd.Next(2, 4);
            }
            return numberToAdd;
        }


    }
}
