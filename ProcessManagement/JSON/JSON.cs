using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Diagnostics;
using System.IO;
using System.Management;
using ProcessManagement.JSON;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
    line1: Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome to JSON management system!\n");
        Console.ResetColor();

        Console.WriteLine("What would you like to do?\n" +
            "1.Create a JSON file\n" +
            "2.Import a JSON file\n");
    line0: int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Create JSON file\n");
                Console.ResetColor();

                int value = CreateJSON();

                if (value == 0)
                {
                    goto line1;
                }

                break;

            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Import JSON file\n");
                Console.ResetColor();

                string path = "C:\\Users\\Saeed.kh\\source\\repos\\ProcessManagement\\ProcessManagement\\bin\\Debug\\jsonFile.json";
                try
                {
                    ImportJSON(path);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No such file founds!");
                    Console.ResetColor();
                    Console.WriteLine("press any key to go to the main menu...");
                    Console.ReadLine();
                    goto line1;
                }
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect number entered!\n");
                Console.ResetColor();
                goto line0;
        }
        Console.ReadKey();
    }
    public static int CreateJSON()
    {
        Console.WriteLine("How many Persons do you want to add?");
        int personsCount = int.Parse(Console.ReadLine());
        List<People> people = new List<People>();

        for (int i = 0; i < personsCount; i++)
        {
            Console.Clear();

            People person = new People();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Creating Person {i + 1}\n");
            Console.ResetColor();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Firstname: ");
            string fname = Console.ReadLine();
            Console.Write("Lastname: ");
            string lname = Console.ReadLine();

            person.Id = id;
            person.firstName = fname;
            person.lastName = lname;

            people.Add(person);

            if (i == personsCount - 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"All people added successfully!");
                Console.ResetColor();
                Console.WriteLine("press any key to continue...");
                Console.ReadLine();
            }
        }
        Console.Clear();
        string json = System.Text.Json.JsonSerializer.Serialize(people);
        string path = "jsonFile.json";
        if (File.Exists(path) == false)
        {
            var file = File.Create(path);
            file.Close();
            File.WriteAllText(path, json);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("JSON File Created Successfully!");
            Console.ResetColor();
        }
        else
        {
            File.WriteAllText(path, json);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("JSON File Updated Successfully!");
            Console.ResetColor();
            Console.WriteLine("press any key to go to the main menu...");
            Console.ReadLine();
            return 0;
        }
        return 1;
    }
    public static void ImportJSON(string path)
    {
        string json = File.ReadAllText(path, Encoding.UTF8);
        List<People> people = JsonConvert.DeserializeObject<List<People>>(json);
        int foreachCounter = 1;
        foreach (var person in people)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Person {foreachCounter}: \n");
            Console.ResetColor();
            Console.WriteLine($"Id: {person.Id}\nfirstname: {person.firstName}\nlastname: {person.lastName}\n\n");
            foreachCounter++;
        }
    }
}