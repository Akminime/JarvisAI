using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Test From Nano!");
        Console.WriteLine("TestInput");
        string input = Console.ReadLine();

        if (input == "")
        {
            input = "No Data";
        }

        Console.WriteLine("<" + input + ">");

        if (input.ToLower() == "add")
        {
            Console.WriteLine("Responding to - 'add'");
            Console.WriteLine("What would you like to add?");
            input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                // You can perform math operations here
                Console.WriteLine("Result: " + (number + 1));
            }
            else
            {
                Console.WriteLine("Invalid input for addition.");
            }
        }
        else if (input.ToLower().StartsWith("open website"))
        {
            // Extract the website URL from the input
            string url = input.Substring("open website".Length).Trim();
            OpenWebsite(url);
        }
        else if (input.ToLower().StartsWith("open application"))
        {
            // Extract the application name from the input
            string appName = input.Substring("open application".Length).Trim();
            OpenApplication(appName);
        }
    }

    static void OpenWebsite(string url)
    {
        try
        {
            Process.Start(url);
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to open the website.");
        }
    }

    static void OpenApplication(string appName)
    {
        try
        {
            Process.Start(appName);
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to open the application.");
        }
    }
}
