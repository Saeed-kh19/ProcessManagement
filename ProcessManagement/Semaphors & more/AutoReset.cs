//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ProcessManagement.Semaphors___more
//{
//    internal class AutoReset
//    {
//        private static AutoResetEvent autoEvent;

//        public static void Main(string[] args)
//        {
//            autoEvent = new AutoResetEvent(false);

//            Console.WriteLine("Starting a new thread...\n");
//            Thread t1 = new Thread(Thread1);
//            t1.Start();

//            Console.WriteLine("Waiting for Thread 2 to signal...\n");

//            autoEvent.WaitOne();
//            Console.WriteLine("Thread 1 Signaled!\n");

//            Console.WriteLine("Press any key to exit...");
//            Console.ReadKey();
//        }

//        static void Thread1()
//        {
//            Console.WriteLine("Thread 1 Started!\n");
//            Thread.Sleep(2000);
//            Console.WriteLine("Thread 1 finished , Signaling Thread 2...\n");
//            autoEvent.Set();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static List<AutoResetEvent> autoEvents;

    public static void Main(string[] args)
    {
        Console.ResetColor();



        autoEvents = new List<AutoResetEvent>();

        for (int i = 0; i < 5; i++)
        {
            autoEvents.Add(new AutoResetEvent(false));
            Thread workerThread = new Thread(WorkerMethod);
            workerThread.Start(i);
        }

        Console.WriteLine("Waiting for all Sub-Threads to signal...\n");


        WaitHandle.WaitAll(autoEvents.ToArray());

        Console.WriteLine("All Sub-Threads signaled!\n");

        Console.WriteLine("Press any key to exit...\n");
        Console.ReadKey();
    }

    static void WorkerMethod(object state)
    {
        int workerId = (int)state;

        Console.WriteLine($"Sub-Thread {workerId} started!\n");

        Thread.Sleep(new Random().Next(1000, 5000));

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Sub-Thread {workerId} finished, signaling Main Thread...\n");
        Console.ResetColor();

        autoEvents[workerId].Set();
    }
}
