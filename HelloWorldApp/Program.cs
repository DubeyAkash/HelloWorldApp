using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAppAPI;
using System.Configuration;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating objects for API classes to write messages on console or to the database.
            HelloWorldConsole hwc = new HelloWorldConsole();
            hwc.SetConsoleMsg("Hellow World!");
            hwc.displayConsoleMessage();

            //similary we can add a code to write messages to database
            HelloWorldDatabase hwd = new HelloWorldDatabase();
            hwd.SetConsoleMsg("Write Hellow World to database");
            hwd.DBWrite();

            //using configuation file to determine where to write the information
            switch (ConfigurationManager.AppSettings["AppType"])
            {
                case "Console":
                    HelloWorldConsole hwcApp = new HelloWorldConsole();
                    hwcApp.SetConsoleMsg("Hello World!");
                    hwcApp.displayConsoleMessage();
                    break;
                case "Database":
                    HelloWorldConsole hwdApp = new HelloWorldConsole();
                    hwdApp.SetConsoleMsg("Hello World!");
                    hwdApp.DBWrite();
                    break;
                default:
                    Console.Write("Invalid option for AppType");
                    break;
            }
            Console.ReadKey();

        }
    }
}
