using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class NumericalExpression
    {
        private long number { get; set; }
        private int numberLen {  get; set; }
        String[] multiplier = {"Houndred", "Thousand", "Million", "Billion", "Trillion" };
        String[] first_twenty = {
            "",        "One",       "Two",      "Three",
            "Four",    "Five",      "Six",      "Seven",
            "Eight",   "Nine",      "Ten",      "Eleven",
            "Twelve",  "Thirteen",  "Fourteen", "Fifteen",
            "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        string[] ty = { "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        long[] multiplierNumbers = { 100, 1000, 1000000, 1000000000 };
        long limit = 999999999999;


        public NumericalExpression(long number)
        {
            this.number = number;
            numberLen = NumberLen(number);
        }
        public long GetValue()
        {
            return number;
        }

        public override string ToString()
        {
            if(number == 0)
            {
                return "zero";
            }
            if(numberLen == 1)
            {
                return LenOne(number);
            }
            if(numberLen == 2)
            {
                return LenTwo(number);
            }
            if (numberLen == 3)
            {
                return LenThree(number);
            }
            if(numberLen > 3 && numberLen < 7)
            {
                return LenFourToSix(number);
            }
            if(numberLen > 6 && numberLen < 10)
            {
                return LenSevenToNine(number);
            }
            return LenTenToTwelve(number);
        }


        private int NumberLen(long number)
        {
            return (number > 0) ? 1 + NumberLen(number / 10) : 0;
        }

        private string LenOne(long number)
        {
            if(number == 0)
            {
                return "";
            }
            return first_twenty[number];
        }
        private string LenTwo(long number)
        {
            if (number == 0)
            {
                return "";
            }
            if (number < 20)
            {
                return first_twenty[number];
            }
            return $"{ty[number / 10 - 1]} {LenOne(number%10)}";
        }
        private string LenThree(long number)
        {
            if (number == 0)
            {
                return "";
            }
            return $"{first_twenty[number / 100]} {multiplier[0]} {LenTwo(number%100)}";
        }

        private string LenFourToSix(long number)
        {
            if (number == 0)
            {
                return "";
            }
            int currentnumberLen = NumberLen(number);
            if (currentnumberLen == 4 || (currentnumberLen == 5 && number/1000 < 20))
            {
                return $"{first_twenty[number / 1000]} {multiplier[1]} {LenThree(number%1000)}";
            }
            else if (currentnumberLen == 5)
            {
                return $"{LenTwo(number/1000)} {multiplier[1]} {LenThree(number%1000)}";
            }
            return $"{LenThree(number/1000)} {multiplier[1]} {LenThree(number % 1000)}";
        }

        private string LenSevenToNine(long number)
        {
            if (number == 0)
            {
                return "";
            }
            int currentnumberLen = NumberLen(number);
            if (currentnumberLen == 7 || (currentnumberLen == 8 && number / 1000000 < 20))
            {
                return $"{first_twenty[number / 1000000]} {multiplier[2]} {LenFourToSix(number % 1000000)}";
            }
            else if (currentnumberLen == 8)
            {
                return $"{LenTwo(number / 1000000)} {multiplier[2]} {LenFourToSix(number % 1000000)}";
            }
            return $"{LenThree(number/1000000)} {multiplier[2]} {LenFourToSix(number % 1000000)}";
        }

        private string LenTenToTwelve(long number)
        {
            int currentnumberLen = NumberLen(number);
            if (currentnumberLen == 10 || (currentnumberLen == 11 && number / 1000000000 < 20))
            {
                return $"{first_twenty[number / 1000000000]} {multiplier[3]} {LenSevenToNine(number % 1000000000)}";
            }
            else if (currentnumberLen == 11)
            {
                return $"{LenTwo(number / 1000000000)} {multiplier[3]} {LenSevenToNine(number % 1000000000)}";
            }
            return $"{LenThree(number / 1000000000)} {multiplier[3]} {LenSevenToNine(number % 1000000000)}";
        }

















        public long SumLetters()
        {
            long someLetters = 0;
            for (long i = 1; i <= number; i++)
            {
                someLetters += (new NumericalExpression(i)).ToString().Trim().Length;
            }
            return someLetters;
        }


        /*polymorphism
         * becuase I actually used the same function but "override" the previous 
         * one because I added another variable that I need to receive
        */
        public long SumLetters(NumericalExpression n)
        {
            long someLetters = 0;
            for (long i = 1; i <= n.GetValue(); i++)
            {
                someLetters += (new NumericalExpression(i)).ToString().Trim().Length;
            }
            return someLetters;
        }
    }
}
