using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set variables
            int selection;
            string processToRun;

        //Menu Design
        line0: Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Welcome to process management application!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please select an action: \n");
            Console.WriteLine("1. Run a process");
            Console.WriteLine("2. List processes");
            Console.WriteLine("3. Kill a process");
            Console.WriteLine("4. Hirearchy of a specific process\n");
        line1: try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                selection = int.Parse(Console.ReadLine());
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Please enter a number! try again");
                goto line1;
            }
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Type your proccess to run");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" (or press (b) to back to main menu)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(":\n");
                    while (true)
                    {

                    line2: Console.ForegroundColor = ConsoleColor.Yellow;
                        processToRun = Console.ReadLine();
                        if (processToRun == "b")
                        {
                            goto line0;
                        }
                        try
                        {
                            runProcess(processToRun);
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect command!");
                            Console.ResetColor();
                            goto line2;
                        }
                    }
                case 2:
                    Console.Clear();

                    break;
                case 3:
                    Console.Clear();

                    break;
                case 4:
                    Console.Clear();

                    break;
                default:
                    Console.WriteLine("Incorrect number! try again");
                    goto line1;
            }
            Console.ReadKey();

        }
        static void runProcess(string process)
        {
            Process.Start(process);
        }
        static void listProcess()
        {

        }
        static void killProcess()
        {

        }
        static void processTree()
        {

        }
    }
}
