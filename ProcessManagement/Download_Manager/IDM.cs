using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public static void File()
        {

        }

        public static void Download(string url,string directory)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged += ((sender, e) =>
                    {
                        Console.WriteLine($"Downloaded {e.BytesReceived} bytes out of {e.TotalBytesToReceive} bytes ({e.ProgressPercentage}%)");
                    });

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
