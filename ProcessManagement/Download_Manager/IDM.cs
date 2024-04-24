using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagement.Download_Manager
{
    internal class IDM
    {
        public static void Main(string[] args)
        {   
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Internet Download Manager (IDM)!");
            Console.ResetColor();


            Console.ReadKey();
        }
        public static void Download(string url,string directory)
        {
            try
            {
                Console.WriteLine($"File '{url}' is downloading...");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
