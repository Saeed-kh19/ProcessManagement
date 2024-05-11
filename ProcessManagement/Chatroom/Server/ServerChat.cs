using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        //Getting tcp server and port number
        TcpListener tcpServer = null;
        int port = 5000;

        try
        {
            //Starting Servers!
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            tcpServer = new TcpListener(ip, port);
            tcpServer.Start();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Server Started. Listening...");
            Console.ResetColor();

            while (true)
            {
                using (TcpClient client = tcpServer.AcceptTcpClient())
                using (NetworkStream ns = client.GetStream())
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = ns.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        memoryStream.Write(buffer, 0, bytesRead);
                    }

                    byte[] fileData = memoryStream.ToArray();
                    string fileName = GenerateFileName("received_file", fileData);
                    string savePath = Path.Combine(Environment.CurrentDirectory, fileName);

                    File.WriteAllBytes(savePath, fileData);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"File Successfully Saved!");
                    Console.ResetColor();
                }
            }
        }
        catch (Exception ex)
        {
            //Error Handeling
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.ResetColor();
        }
        finally
        {
            tcpServer?.Stop();
        }
    }

    static string GenerateFileName(string baseName, byte[] fileData)
    {
        //Generagting File names!
        string extension = GetFileExtension(fileData);
        return $"{baseName}{extension}";
    }

    static string GetFileExtension(byte[] fileData)
    {

        //Detect file extentions!...
        Dictionary<string, string> fileSignatures = new Dictionary<string, string>()
        {
            { "FFD8FF", ".jpg" }, // JPEG
            { "89504E47", ".png" }, // PNG
            { "47494638", ".gif" }, // GIF
            { "25504446", ".pdf" } // PDF
        };

        byte[] signatureBytes = new byte[4];

        // Extract first 4 bytes of the file
        Array.Copy(fileData, signatureBytes, 4);

        string signature = BitConverter.ToString(signatureBytes).Replace("-", "");

        if (fileSignatures.ContainsKey(signature))
        {
            return fileSignatures[signature];
        }
        else
        {
            //default file extention
            return ".dat";
        }
    }
}