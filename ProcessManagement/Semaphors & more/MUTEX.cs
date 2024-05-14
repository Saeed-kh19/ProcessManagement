using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProcessManagement.Semaphors___more
{
    internal class MUTEX
    {
        static void Main(string[] args)
        {
            Mutex mutex = new Mutex(true, "myAppMutex");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (!mutex.WaitOne(TimeSpan.FromSeconds(5)) == false)
                    {
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Another instance of the app is running!\n");
                        Console.ResetColor();
                    }
                    RunProgram();
                }
                catch (Exception e)
                {
                    if (mutex != null)
                    {
                        mutex.Close();
                        mutex = null;
                    }
                }
                if (i==4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Program finished! press any key to exit...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        static void RunProgram()
        {
            Thread.Sleep(3000);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Running program...\n");
            Console.ResetColor();
        }
    }
}