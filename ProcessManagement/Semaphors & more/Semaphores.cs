using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessManagement.Semaphors___more
{
    internal class Semaphores
    {
        static Semaphore s = new Semaphore(2, 2);
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("<Semaphores Exercise>\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 5; i++)
            {
                Thread th = new Thread((Object obj) =>
                {
                    s.WaitOne(); //s--
                    Console.WriteLine("Start with: " + obj.ToString() + "\n");
                    Thread.Sleep(3000);
                    Console.WriteLine("End with: " + obj.ToString() + "\n");
                    s.Release(); //s++
                });
                th.Start(i + 1);
            }

            Console.ReadKey();
        }
    }
}
