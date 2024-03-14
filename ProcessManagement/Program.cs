using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ProcessManagement
{
    internal class Program
    {

        // Import the OpenProcess function from the Windows API
        [DllImport("kernel32.dll")]
        static extern int GetProcessId(IntPtr handle);
        public static void Main(string[] args)
        {
            //Create variables
            int selection;
            string processToRun;
            int processToKill;
            int processToTree;
            string waitForKey;


        //Menu Design
        line0: Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Welcome to process management application!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("Please select an action: \n");
            Console.WriteLine("1. Run a process");
            Console.WriteLine("2. List processes");
            Console.WriteLine("3. Kill a process");
            Console.WriteLine("4. Hirearchy of a specific process\n");

        //Choices
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
                    Console.Write(":\n\n");
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
                    listProcess();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress (b) to back to main menu...");
                    Console.ResetColor();
                    waitForKey = Console.ReadLine();
                    while (waitForKey != "b")
                    {
                        waitForKey = Console.ReadLine();
                    }
                    goto line0;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Type your proccess's ID to kill");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" (or press (-1) to back to main menu)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(":\n\n");
                    while (true)
                    {

                    line3: Console.ForegroundColor = ConsoleColor.Yellow;

                        try
                        {
                            processToKill = int.Parse(Console.ReadLine());
                            if (processToKill == -1)
                            {
                                goto line0;
                            }
                            killProcess(processToKill);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Process killed successfully!");

                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Illegal ID!");
                            Console.ResetColor();
                            goto line3;
                        }
                    }

                case 4:
                    Console.Clear();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Type your proccess's ID");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" (or press (-1) to back to main menu)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(":\n\n");
                    while (true)
                    {

                    line4: Console.ForegroundColor = ConsoleColor.Yellow;

                        try
                        {
                            processToTree = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                            if (processToTree == -1)
                                goto line0;
                            processTree(processToTree);
                        }
                        catch (Exception)
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Illegal ID!");
                            Console.ResetColor();
                            goto line4;
                        }
                    }
                default:
                    Console.WriteLine("Incorrect number! try again");
                    goto line1;
            }
        }
        static void runProcess(string process)
        {
            Process.Start(process);
        }
        static void listProcess()
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(process.Id);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\t{process.ProcessName}\n");
                Console.ResetColor();
            }
        }
        static void killProcess(int processId)
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (process.Id == processId)
                {
                    process.Kill();
                }
            }
        }
        public static void processTree(int pid)
        {
            IntPtr processHandle;
            Process[] processList = Process.GetProcesses();
            for (int i = 0; i < processList.Length; i++)
            {
                if (processList[i].Id == pid)
                {
                    processHandle = Process.GetProcessById(pid).Handle;
                    foreach (var proc in processList)
                    {
                        if (proc.Handle == processHandle)
                        {
                            Console.WriteLine(proc.ProcessName);
                        }
                    }
                }
            }
        }
    }
}