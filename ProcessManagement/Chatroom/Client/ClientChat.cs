﻿using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

public class ClientChat
{
    public static void Main(string[] args)
    {
        //Enterting server port number
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enter Server Port Number:");
        Console.ResetColor();

        int port = int.Parse(Console.ReadLine());

        //Entering file path
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEnter File Path:");
        Console.ResetColor();

        string filePath = Console.ReadLine();

        try
        {
            //Creating TCP Client
            using (TcpClient server = new TcpClient("127.0.0.1", port))
            using (NetworkStream ns = server.GetStream())
            using (FileStream fs = File.OpenRead(filePath))
            {
                fs.CopyTo(ns);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File sent successfully.");
                Console.ResetColor();
            }
        }
        catch (Exception e)
        {
            //Error Handling
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("an Error Occured!");
            Console.ResetColor();
        }
        Console.ReadKey();
    }
}