using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to process management application!\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("select an action you want to do: ");
            Console.ReadKey();
        }
    }
}
