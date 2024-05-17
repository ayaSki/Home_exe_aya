using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game.Logic
{
    public class logicalFunctions
    {
        public string NumberToStr(int number)
        {
            if (number == 0)
            {
                return DuplicateSpace(4);
            }
            if (NumberLen(number) == 1)
            {
                return $"{number.ToString()}{DuplicateSpace(3)}";
            }
            if (NumberLen(number) == 2)
            {
                return $"{number.ToString()}{DuplicateSpace(2)}";
            }
            if (NumberLen(number) == 3)
            {
                return $"{number.ToString()}{DuplicateSpace(1)}";
            }
            return number.ToString();
        }

        private int NumberLen(int number)
        {
            return (number > 0) ? 1 + NumberLen(number / 10) : 0;
        }

        private string DuplicateSpace(int number)
        {
            string longSpace = "";
            for (int i = 0; i < number; i++)
            {
                longSpace += constants.Space;
            }
            return longSpace;
        }
    }
}
