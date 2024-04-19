using ProcessManagement.JSON;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;

class Program
{
    static void Main(string[] args)
    {
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

                CreateJSON();

                break;
            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Import JSON file\n");
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect number entered!\n");
                Console.ResetColor();
                goto line0;
        }
        Console.ReadKey();
    }
    public static void CreateJSON()
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
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"All people added successfully!");
        Console.ResetColor();
    }
}
