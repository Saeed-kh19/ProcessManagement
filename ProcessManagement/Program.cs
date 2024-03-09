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
            //set variables
            int selection;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to process management application!\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please select an action: \n");
            Console.WriteLine("1. Run a process");
            Console.WriteLine("2. List processes");
            Console.WriteLine("3. Kill a process");
            Console.WriteLine("4. Hirearchy of a specific process");
line1:      try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number! try again");
                goto line1;
            }
            switch (selection)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                default:
                    Console.WriteLine("Incorrect number! try again");
                    goto line1;
            }
            Console.ReadKey();

        }
    }
}
