using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static List<AutoResetEvent> autoEvents;

    public static void Main(string[] args)
    {

        //Welcomizations!
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("<AutoResetEvent Exercise>\n\n");
        Console.ResetColor();

        //Creating a generic list of auto reset event
        autoEvents = new List<AutoResetEvent>();

        //Creating and starting 5 Threads...!
        for (int i = 0; i < 5; i++)
        {
            autoEvents.Add(new AutoResetEvent(false));
            Thread subThread = new Thread(SubThread);
            subThread.Start(i);
        }

        Console.WriteLine("Waiting for all Sub-Threads to signal...\n");

        WaitHandle.WaitAll(autoEvents.ToArray());

        Console.WriteLine("All Sub-Threads signaled!\n");

        //Finishing program and waiting for a key to exit the program...!
        Console.WriteLine("\nProgram Finished! Press any key to exit...\n");
        Console.ReadKey();
    }

    //Functions for sub threads!...
    static void SubThread(object state)
    {
        //Creating Id for threads (with usage of their states!)
        int subThreadId = (int)state;

        Console.WriteLine($"Sub-Thread {subThreadId} started!\n");

        //Waiting for a random time!
        Thread.Sleep(new Random().Next(1000, 5000));

        Console.WriteLine($"Sub-Thread {subThreadId} finished, Signaling Main Thread...\n");

        autoEvents[subThreadId].Set();
    }
}
