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
        watcher.EventArrived += Insert;
        watcher.Query = query;
        watcher.Start();
        Console.ReadLine();
        watcher.Stop();
    }
    static void Insert(object sender, EventArrivedEventArgs e)
    {
        string driveLetter = e.NewEvent.Properties["DriveName"].Value.ToString();
        DriveInfo driveInfo = new DriveInfo(driveLetter);

        if (driveInfo.DriveType == DriveType.Removable)
        {
            try
            {
                Process.Start("mspaint.exe");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Flash disk ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{driveInfo.VolumeLabel}");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write(" detected successfully!");
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occured!");
                Console.ResetColor();
            }
        }
    }
}

