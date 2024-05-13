using _2048Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.User
{
    public class ConsoleGame
    {
        public Board Board {  get; set; }
        public void ShowBoard()
        {
            for(int i = 0; i < constants.BoardSize; i++)
            {
                for(int j = 0; j < constants.BoardSize; j++)
                {
                    Console.Write(Board.Data[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
