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
    static void Insert(object sender, EventArrivedEventArgs e)
    {
        string driveLetter = e.NewEvent.Properties["DriveName"].Value.ToString();
        DriveInfo driveInfo = new DriveInfo(driveLetter);

        if (driveInfo.DriveType == DriveType.Removable)
        {
            try
            {
                Process.Start("mspaint.exe");
            }
            catch (Exception)
            {
                Console.WriteLine($"An error occured!");
            }
        }
    }
}

