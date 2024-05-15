using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static List<AutoResetEvent> autoEvents;

    public static void Main(string[] args)
    {

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("<AutoResetEvent Exercise>\n\n");
        Console.ResetColor();


        autoEvents = new List<AutoResetEvent>();

        for (int i = 0; i < 5; i++)
        {
            autoEvents.Add(new AutoResetEvent(false));
            Thread subThread = new Thread(SubThread);
            subThread.Start(i);
        }

        Console.WriteLine("Waiting for all Sub-Threads to signal...\n");


        WaitHandle.WaitAll(autoEvents.ToArray());

        Console.WriteLine("All Sub-Threads signaled!\n");

        Console.WriteLine("\nProgram Finished! Press any key to exit...\n");
        Console.ReadKey();
    }

    static void SubThread(object state)
    {
        int subThreadId = (int)state;

        Console.WriteLine($"Sub-Thread {subThreadId} started!\n");

        Thread.Sleep(new Random().Next(1000, 5000));

        Console.WriteLine($"Sub-Thread {subThreadId} finished, Signaling Main Thread...\n");

        autoEvents[subThreadId].Set();
    }
}
