using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hej. Welcome to the spare parts inventory!");
        Console.WriteLine("Which part do you need?");

        while (true)
        {
            string part = Console.ReadLine().ToLower();
            
            if (part == "do you actually have any parts?")
            {
                Console.WriteLine("We have 3 part(s):");
                Console.WriteLine("hydraulic pump");
                Console.WriteLine("plc module");
                Console.WriteLine("servo motor");
            }
            else if (part == "is there anything in stock at all?")
            {
                Console.WriteLine("We have 3 part(s):");
                Console.WriteLine("hydraulic pump");
                Console.WriteLine("plc module");
                Console.WriteLine("servo motor");
            }
            else if (part == "hydraulic pump")
            {
                Console.WriteLine("I have got hydraulic pump here for you. Bye.");
                break;
            }
            else if (part == "plc module")
            {
                Console.WriteLine("I have got plc module here for you. Bye.");
                break;
            }
            else if (part == "servo motor")
            {
                Console.WriteLine("I have got servo motor here for you. Bye.");
                break;
            }
            else
            {
                Console.WriteLine("I am afraid we don't have any " + part + " in the inventory.");
                Console.WriteLine("Which part do you need?");
            }
        }
    }
}
