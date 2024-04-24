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
            Console.WriteLine("Welcome to Internet Download Manager (IDM)!");
            Console.ResetColor();

            Download download = new Download();
            download.DownloadFile("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8Wz_QKY_UtRFVAHxm44oFJSh_GVFVKAARNaELlKERUQ&s","./");

            Console.ReadKey();
        }


        public class Download
        {

            public void DownloadFile(string url, string directory)
            {
                try
                {
                    Console.WriteLine($"Downloading {url}...");

                    Thread downloadThread = new Thread( ()=> DownloadProcess("param1","param2") );
                    downloadThread.Start();

                    downloadThread.Join();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Download Completed!");
                    Console.ResetColor();

                }
                catch (Exception)
                {

                    throw;
                }
            }

            public void DownloadProcess(string url,string directory)
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadProgressChanged += (sender, e) =>
                        {
                            Console.WriteLine($"Downloaded {e.BytesReceived} bytes out of {e.TotalBytesToReceive} bytes ({e.ProgressPercentage}%)");
                        };

                        client.DownloadFile(new Uri(url), directory);
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"an Error occured!");
                    Console.ResetColor();
                }
            }
        }
    }
}
