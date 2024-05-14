//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ProcessManagement.Semaphors___more
//{
//    internal class @lock
//    {
//        private readonly static object _lockObject = new object();

//        public static void Process()
//        {
//            bool lockTaken = false;
//            try
//            {
//                Monitor.Enter(_lockObject, ref lockTaken);

//                // Your code here.
//                Console.WriteLine("Locked section is running.");
//            }
//            finally
//            {
//                if (lockTaken)
//                {
//                    Monitor.Exit(_lockObject);
//                }
//            }
//        }

//        public static void Main(string[] args)
//        {
//            Process();
//            Console.ReadKey();
//        }
//    }
//}
