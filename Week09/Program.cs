using System;
using System.Collections.Generic;

class program
{
    
    static void Main(string[] args)
    {

        List<string> toDoList = new List<string>();

        while (true)
        {
            Console.WriteLine("Hi! Welcome to da list!");

            string command = Console.ReadLine();

            if (command == "Add")
            {
                Console.WriteLine("Enter an item");
                string item = Console.ReadLine();
 
                toDoList.Add(item);
            } 
            else if (command == "View")
            {
                if (toDoList.Count <= 0)
                {
              
                Console.WriteLine("No items added.");
               }
                Console.WriteLine(toDoList.Count); 
                 ViewList(toDoList);
            }
            else if (command == "Exit")
            {
                Console.WriteLine("Thanks for viewing da list!");
                break;
            }
        } 
    } 
    public static void ViewList(List<string> list)
    {
        foreach (string A in list)
        {
            Console.WriteLine("- " + A);
        }
    }
}



