using System;
using System.Diagnostics;
using System.IO;
using System.Management;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert your flash drive:");

        ManagementEventWatcher watcher = new ManagementEventWatcher();
        WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
        watcher.Query = query;
        watcher.Start();
        Console.ReadLine();
        watcher.Stop();
    }

}

