using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var inventory = GetInventory();

        Console.WriteLine("Welcome to our spare parts inventory system.");
        Console.WriteLine("Type the name of the part you are looking for.");

        bool partFound = false;
        while (!partFound)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Input was empty. Please enter a part name.");
            }
            else if (IsGeneralStockQuestion(userInput))
            {
                PrintInventory(inventory);
            }
            else
            {
                string match = FindPart(inventory, userInput);

                if (match != null)
                {
                    Console.WriteLine("The part \"" + match + "\" is available.");
                    partFound = true;
                }
                else
                {
                    Console.WriteLine("That part is not available in our inventory.");
                }
            }
        }

        Console.WriteLine("Thank you for using the inventory system.");
    }

    static Dictionary<string, string> GetInventory()
    {
        return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "hydraulic pump", "Hydraulic pump" },
            { "PLC module", "PLC module" },
            { "servo motor", "Servo motor" }
        };
    }

    static bool IsGeneralStockQuestion(string input)
    {
        var generalQuestions = new List<string>
        {
            "Do you actually have any parts?",
            "Is there anything in stock at all?"
        };

        return generalQuestions.Exists(q => string.Equals(q, input, StringComparison.OrdinalIgnoreCase));
    }

    static void PrintInventory(Dictionary<string, string> inventory)
    {
        Console.WriteLine("Current inventory (" + inventory.Count + " items):");
        foreach (var item in inventory)
        {
            Console.WriteLine("- " + item.Value);
        }
    }

    static string FindPart(Dictionary<string, string> inventory, string userInput)
    {
        foreach (var entry in inventory)
        {
            if (entry.Key.Equals(userInput, StringComparison.OrdinalIgnoreCase))
            {
                return entry.Value;
            }
        }

        return null;
    }
}