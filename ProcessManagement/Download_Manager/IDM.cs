using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessManagement.Download_Manager
{
    internal class IDM
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Internet Download Manager (IDM)!\n");
            Console.ResetColor();

            Console.WriteLine("How many links do you want to download?");
            int downloadCounter = int.Parse(Console.ReadLine());


            string[] urls = new string[downloadCounter];
            string[] directories = new string[downloadCounter];


            Console.Clear();

            for (int i = 0; i < downloadCounter; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"File {i + 1}\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your url: ");
                Console.ResetColor();

                urls[i] = Console.ReadLine();


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your directory and file name: ");
                Console.ResetColor();

                directories[i] = Console.ReadLine();

                Console.ResetColor();

                Console.Clear();
            }

            Console.Clear();

            for (int i = 0; i < downloadCounter; i++)
            {
                Download download = new Download();
                download.DownloadFile(urls[i], directories[i], downloadCounter);
            }

            Console.ReadKey();
        }


        public class Download
        {

            public void DownloadFile(string url, string directory, int downloadCounter)
            {
                Thread[] threads = new Thread[downloadCounter];

                try
                {
                    Console.WriteLine($"Downloading {url}...");
                    for (int i = 0; i < downloadCounter; i++)
                    {
                        threads[i] = new Thread(() => DownloadProcess(url, directory));
                    }
                    for (int i = 0; i < downloadCounter; i++)
                    {
                        threads[i].Start();
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void DownloadProcess(string url, string directory)
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(new Uri(url), directory);
                        client.DownloadProgressChanged += ((sender, e) =>
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Downloaded {e.BytesReceived} bytes out of {e.TotalBytesToReceive} bytes ({e.ProgressPercentage}%)");
                            Console.ResetColor();
                        });
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Downloads of '{url}' Completed!");
                    Console.ResetColor();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"an Error occured for '{url}'!");
                    Console.ResetColor();
                }
            }
        }
    }
}
