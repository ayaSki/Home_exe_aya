﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            int addPoints = 0;
            switch (direction)
            {
                case Enums.Direction.Up:
                    addPoints = MoveByQueue(1);
                    break;
                case Enums.Direction.Down:
                    addPoints = MoveByQueue(-1);
                    break;
                case Enums.Direction.Left:
                    addPoints = MoveByRow(-1);
                    break;
                default:
                    addPoints = MoveByRow(1);
                    break;
            }
            return addPoints;
        }




        private int MoveByRow(int direction)
        {
            int addPoints = 0;
            for (int i = 0; i < constants.BoardSize; i++)
            {
                if (Data[i, 1] == Data[i, 2])
                {
                    addPoints = ConnectIdenticall(new int[] { i, 1 }, new int[] { i, 2 }, direction);
                }
                else
                {
                    if (Data[i, 0] == Data[i, 1])
                    {
                        addPoints = ConnectIdenticall(new int[] { i, 0 }, new int[] { i, 1 }, direction);
                    }
                    if (Data[i, 2] == Data[i, 3])
                    {
                        addPoints =ConnectIdenticall(new int[] { i, 2 }, new int[] { i, 3 }, direction);
                    }
                }
                ArrengeRow(direction, i);
            }
            return addPoints;
        } 

        private void ArrengeRow(int direction, int rowNumber)
        {
            int[] rowNumbers = new int[constants.BoardSize];
            int startPoint = 0;
            int location = 0;
            if(direction == -1)
            {
                startPoint = 1;
            }
            for(int i = startPoint; i < constants.BoardSize; i++)
            {
                if (Data[rowNumber, location] != 0)
                {
                    rowNumbers[i] = Data[rowNumber, location];
                }
                location++;
            }
            for(int i = 0; i < constants.BoardSize; i++)
            {
                Data[rowNumber, i] = rowNumbers[i];
            }
        }

        private int ConnectIdenticall(int[] firstLoc, int[] secondLoc, int direction)
        {
            if (direction == 1)//up
            {
                Data[firstLoc[0], firstLoc[1]] =
                    Data[firstLoc[0], firstLoc[1]] + Data[secondLoc[0], secondLoc[1]];
                Data[secondLoc[0], secondLoc[1]] = 0;
                return Data[firstLoc[0], firstLoc[1]];
            }
            //down
            Data[secondLoc[0], secondLoc[1]] =
                    Data[firstLoc[0], firstLoc[1]] + Data[secondLoc[0], secondLoc[1]];
            Data[firstLoc[0], firstLoc[1]] = 0;
            return Data[secondLoc[0], secondLoc[1]];
        }


        private int MoveByQueue(int direction)
        {
            int addPoints = 0;
            for (int i = 0; i < constants.BoardSize; i++)
            {
                if (Data[1, i] == Data[2, i])
                {
                    addPoints = ConnectIdenticall(new int[] { 1, i }, new int[] { 2, i }, direction);
                }
                else
                {
                    if (Data[0, i] == Data[1, i])
                    {
                        addPoints = ConnectIdenticall(new int[] { 0, i }, new int[] { 1, i }, direction);
                    }
                    if (Data[2, i] == Data[3, i])
                    {
                        addPoints = ConnectIdenticall(new int[] { 2, i }, new int[] { 3, i }, direction);
                    }
                }
                ArrengeQueue(direction, i);
            }
            return addPoints;
        }

        private void ArrengeQueue(int direction, int queueNumber)
        {
            int[] queueNumbers = new int[constants.BoardSize];
            int startPoint = 0;
            int location = 0;
            if (direction == -1)
            {
                startPoint = 1;
            }
            for (int i = startPoint; i < constants.BoardSize; i++)
            {
                if (Data[location, queueNumber] != 0)
                {
                    queueNumbers[i] = Data[location, queueNumber];
                }
                location++;
            }
            for (int i = 0; i < constants.BoardSize; i++)
            {
                Data[i, queueNumber] = queueNumbers[i];
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