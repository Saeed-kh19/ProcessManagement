using System;
using System.Diagnostics;
using System.IO;
using System.Management;

class Program
{
    static void Main(string[] args)
    {
        //Welcomization!
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please insert your flash drive (or press Enter for exitting the program): ");
        Console.ResetColor();

        //Listening for flash disk insertion
        ManagementEventWatcher watcher = new ManagementEventWatcher();
        WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
        watcher.EventArrived += Insert;
        watcher.Query = query;
        watcher.Start();
        //If user wants to exit
        Console.ReadLine();
        watcher.Stop();
    }
    static void Insert(object sender, EventArrivedEventArgs e)
    {
        //Detecting flash drive and fetching its specifications
        string driveLetter = e.NewEvent.Properties["DriveName"].Value.ToString();
        DriveInfo driveInfo = new DriveInfo(driveLetter);
        
        //Running 'mspaint.exe' process...!
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

