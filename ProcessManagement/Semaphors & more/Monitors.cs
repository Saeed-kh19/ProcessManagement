//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

namespace ProcessManagement.Semaphors___more
{
    internal class Monitors
    {
        private static object lockObject = new object();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(DoWork);
            Thread thread2 = new Thread(DoWork);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.ReadKey();
        }

        static void DoWork()
        {
            Monitor.Enter(lockObject);
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thread {0} acquired the lock", Thread.CurrentThread.ManagedThreadId);

                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Hello this code is working into Thread {0}!",Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("We are still in Thread {0}!",Thread.CurrentThread.ManagedThreadId);

//            //Releasing the monitor!
//            finally
//            {
//                Monitor.Exit(lockObject);
//            }

                Thread.Sleep(2000);
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }
    }
}
