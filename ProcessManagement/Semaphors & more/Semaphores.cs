//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ProcessManagement.Semaphors___more
//{
//    internal class Semaphores
//    {
//        //Creating a variable for our semaphore (with length of 2)
//        static Semaphore s = new Semaphore(2, 2);

//        public static void Main(string[] args)
//        {
//            //Welcomizations!
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine("<Semaphores Exercise>\n\n");
//            Console.ResetColor();

//            Console.ForegroundColor = ConsoleColor.Yellow;

//            //Loop for creating and starting 5 threads for our simulations!
//            for (int i = 0; i < 5; i++)
//            {
//                //Creating new Threads!
//                Thread th = new Thread((Object obj) =>
//                {
//                    //Take control of Semaphore!
//                    s.WaitOne(); //s--
//                    Console.WriteLine("Start with: " + obj.ToString() + "\n");

//                    //Wait 3 seconds between our processes!
//                    Thread.Sleep(3000);

//                    Console.WriteLine("End with: " + obj.ToString() + "\n");
//                    //Release semaphore!
//                    s.Release(); //s++
//                });

//                //Starting the threads!
//                th.Start(i + 1);
//            }

//            //Code to read a key before exitting the program!
//            Console.ReadKey();
//        }
//    }
//}
