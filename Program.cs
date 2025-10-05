// See https://aka.ms/new-console-template for more information
// BAPTISTA, Nicko Adrian E.
// from BSCS 3-2

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> todoList = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== TO-DO LIST MANAGER ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter task to add: ");
                    string task = Console.ReadLine();
                    todoList.Add(task);
                    Console.WriteLine("Task added!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Your Tasks ---");
                    if (todoList.Count == 0)
                    {
                        Console.WriteLine("No tasks yet!");
                    }
                    else
                    {
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                    }
                    break;

                case "3":
                    Console.Write("Enter task number to remove: ");
                    int removeIndex;
                    if (int.TryParse(Console.ReadLine(), out removeIndex) &&
                        removeIndex >= 1 && removeIndex <= todoList.Count)
                    {
                        todoList.RemoveAt(removeIndex - 1);
                        Console.WriteLine("Task removed!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number!");
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting program... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
