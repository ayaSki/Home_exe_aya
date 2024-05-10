using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class NumericalExpression
    {
        public long number {  get; set; }
        String[] multiplier = {"" ,"Houndred", "Thousand", "Million", "Billion", "Trillion" };
        String[] first_twenty = {
            "Zero",        "One",       "Two",      "Three",
            "Four",    "Five",      "Six",      "Seven",
            "Eight",   "Nine",      "Ten",      "Eleven",
            "Twelve",  "Thirteen",  "Fourteen", "Fifteen",
            "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        string[] ty = { "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
        long[] multiplierNumbers = {100 ,1000, 1000000, 1000000000};
        long limit = 999999999999;


    public NumericalExpression(long number)
        {
            this.number = number;
        }
        public long GetValue()
        {
            return number;
        }

        public override string ToString()
        {
            return $"{GetBillion(number)} {GetMillion(number/1000)} {GetThousand(number/10000)} {GetTeens(number/100000)}";
            

        }

        private string GetTeens(long number)
        {
            if (number % 10 == 0)
                return ty[number / 10 - 1];
            return $"{ty[number / 10 - 1]} {first_twenty[number%10]}";
        }

        private string GetHundred(int number)
        {
            if (number / multiplierNumbers[0] != 0)
            {
                return $"{first_twenty[number / 100]} {multiplier[1]}";
            }
            return "";
        }
        private string GetThousand(long number)
        {
            if (number / multiplierNumbers[1] != 0)
            {
                return $"{first_twenty[number / 1000]} {multiplier[2]}";
            }
            return "";
        }

        private string GetMillion(long number)
        {
            if (number / multiplierNumbers[2] != 0)
            {
                return $"{first_twenty[number / 1000000]} {multiplier[3]}";
            }
            return "";
        }

        private string GetBillion(long number)
        {
            if (number / multiplierNumbers[3] != 0)
            {
                return $"{first_twenty[number / 1000000000]} {multiplier[4]}";
            }
            return "";
        }

        private long SumLetters()
        {
            long someLetters = 0;
            for(long i = 0; i < number; i++)
            {
                someLetters += (new NumericalExpression(i)).ToString().Trim().Length;
            }
            return someLetters;
        }


        //
        private long SumLetters(NumericalExpression n)
        {
            long someLetters = 0;
            for (long i = 0; i < number; i++)
            {
                someLetters += n.ToString().Trim().Length;
            }
            return someLetters;
        }
    }
}
