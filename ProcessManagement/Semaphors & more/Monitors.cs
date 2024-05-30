//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

<<<<<<< HEAD
//namespace ProcessManagement.Semaphors___more
//{
//    internal class Monitors
//    {
//        //Creating an object for our lock!
//        private static object lockObject = new object();

//        static void Main(string[] args)
//        {
//            //Welcomizations!
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine("<Monitors Exercise>\n\n");
//            Console.ResetColor();

//            //Creating Threads!!
//            Thread t1 = new Thread(MonFunctions);
//            Thread t2 = new Thread(MonFunctions);

//            //Starting Threads
//            t1.Start();
//            t2.Start();

//            t1.Join();
//            t2.Join();

//            //Exiting the program!
//            Console.ResetColor();
//            Console.WriteLine("\n\nProgram Finished! Press any key to exit...");
//            Console.ReadKey();
//        }

//        //a Functions for our Monitors and working with threads!
//        static void MonFunctions()
//        {
=======
namespace ProcessManagement.Semaphors___more
{
    internal class Monitors
    {
        //Creating an object for our lock!
        private static object lockObject = new object();

        static void Main(string[] args)
        {
            //Welcomizations!
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("<Monitors Exercise>\n\n");
            Console.ResetColor();

            //Creating Threads!!
            Thread t1 = new Thread(MonFunctions);
            Thread t2 = new Thread(MonFunctions);

            //Starting Threads
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            //Exiting the program!
            Console.ResetColor();
            Console.WriteLine("\n\nProgram Finished! Press any key to exit...");
            Console.ReadKey();
        }

        //a Functions for our Monitors and working with threads!
        static void MonFunctions()
        {

            //Acquiring the monitor!
            Monitor.Enter(lockObject);
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thread {0} acquired the lock", Thread.CurrentThread.ManagedThreadId);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hello this code is working into Thread {0}!", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("We are still in Thread {0}!", Thread.CurrentThread.ManagedThreadId);
>>>>>>> e2364fea8821f02da3fe1eb02278a46dd344673f

//            //Acquiring the monitor!
//            Monitor.Enter(lockObject);
//            try
//            {
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("Thread {0} acquired the lock", Thread.CurrentThread.ManagedThreadId);

<<<<<<< HEAD
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.WriteLine("Hello this code is working into Thread {0}!", Thread.CurrentThread.ManagedThreadId);
//                Console.WriteLine("We are still in Thread {0}!", Thread.CurrentThread.ManagedThreadId);

//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Thread {0} released the lock\n", Thread.CurrentThread.ManagedThreadId);
//                Console.ResetColor();

//                Thread.Sleep(2000);
//            }

//            //Releasing the monitor!
//            finally
//            {
//                Monitor.Exit(lockObject);
//            }

//        }
//    }
//}
=======
                Thread.Sleep(2000);
            }

            //Releasing the monitor!
            finally
            {
                Monitor.Exit(lockObject);
            }

        }
    }
}
>>>>>>> e2364fea8821f02da3fe1eb02278a46dd344673f
