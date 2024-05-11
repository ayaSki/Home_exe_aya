using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression n = new NumericalExpression(6678);
            Console.WriteLine($"{n.ToString()}");
            int num = int.Parse(Console.ReadLine());
        }
    }
}
