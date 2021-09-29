using System;

namespace Fritz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Environment.GetEnvironmentVariable("FritzBoxUserName");
            var password = Environment.GetEnvironmentVariable("FritzBoxPassword");

            var fritzBox = new FritzClient()
            {
                UserName = userName,
                Password = password
            };

            // Write csv file to the application folder
            fritzBox.WritePhonebookCsv(name: "Test Phonebook", folder: AppDomain.CurrentDomain.BaseDirectory, separator: ";");
        }
    }
}
