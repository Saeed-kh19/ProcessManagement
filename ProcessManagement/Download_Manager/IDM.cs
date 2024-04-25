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
        line0:
            try
            {
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
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect format of number! try again.");
                Console.ResetColor();
                goto line0;
            }


            Console.ReadKey();
        }


        public class Download
        {

            public void DownloadFile(string url, string directory, int downloadCounter)
            {
                //Thread[] threads = new Thread[downloadCounter];

                //try
                //{
                Console.WriteLine($"Downloading {directory}...");
                //for (int i = 0; i < downloadCounter; i++)
                //{
                //    threads[i] = new Thread(() => DownloadProcess(url, directory));
                Thread thread = new Thread(() => DownloadProcess(url, directory));
                //}
                //for (int i = 0; i < downloadCounter; i++)
                //{
                //    threads[i].Start();
                thread.Start();
                //}

                //}
                //catch (Exception)
                //{

                //    throw;
                //}
            }

            public void DownloadProcess(string url, string directory)
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(new Uri(url), directory);
                        client.DownloadProgressChanged += (sender, e) =>
                        {
                            Console.WriteLine(e.ProgressPercentage);
                        };
                    }
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Downloads of '{directory}' Completed!");
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