using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My first app in C#";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****************************");
            Console.WriteLine("***     0 0 0   0 0 0     ***");
            Console.WriteLine("***   0 0 0 0 0 0 0 0 0   ***");
            Console.WriteLine("*** 0 0 0 0 0 0 0 0 0 0 0 ***");
            Console.WriteLine("*** 0 0 0 0 0 0 0 0 0 0 0 ***");
            Console.WriteLine("***   0 0 0 0 0 0 0 0 0   ***");
            Console.WriteLine("***     0 0 0 0 0 0 0     ***");
            Console.WriteLine("***       0 0 0 0 0       ***");
            Console.WriteLine("***         0 0 0         ***");
            Console.WriteLine("***           0           ***");
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
