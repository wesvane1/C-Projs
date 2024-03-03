using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class ReadJsonFile
{
    static void Main()
    {
        string json = File.ReadAllText("Lab02.json");

        JsonDocument jsonDocument = JsonDocument.Parse(json);
        var usernames = jsonDocument.RootElement.GetProperty("username").EnumerateArray();
        var passwords = jsonDocument.RootElement.GetProperty("password").EnumerateArray();

        Dictionary<string, string> unpw = new Dictionary<string, string>();

        // Iterate over usernames and passwords and add them to the dictionary
        var passwordEnumerator = passwords.GetEnumerator();
        foreach (var usernameElement in usernames)
        {
            if (passwordEnumerator.MoveNext())
            {
                string username = usernameElement.GetString();
                string password = passwordEnumerator.Current.GetString();

                // Check for null values before adding to the dictionary
                if (username != null)
                {
                    unpw.Add(username, password);
                }
            }
            else
            {
                Console.WriteLine("Error: Mismatched number of usernames and passwords.");
                break;
            }
        }

        // Display the dictionary
        DisplayDictionary(unpw);
    }

    static void DisplayDictionary(Dictionary<string, string> unpw)
    {
        foreach (var kvp in unpw)
        {
            Console.WriteLine($"Username: {kvp.Key}, Password: {kvp.Value}");
        }
    }
}
