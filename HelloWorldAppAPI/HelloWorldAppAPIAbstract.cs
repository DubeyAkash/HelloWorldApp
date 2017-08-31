using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAppAPI
{
    public abstract class HelloWorldAppAPIAbstract
    {
        public string consoleMsg { get; set; }
        public string dbConString { get; set; }

        public abstract void displayConsoleMessage();
        public abstract void DBWrite();
    }

    public class HelloWorldConsole : HelloWorldAppAPIAbstract
    {
        public void SetConsoleMsg(string msg)
        {
            base.consoleMsg = msg;
        }

        public override void displayConsoleMessage()
        {
            Console.Write(consoleMsg);
        }

        public override void DBWrite()
        {
            
        }
    }


    public class HelloWorldDatabase : HelloWorldAppAPIAbstract
    {
        public void SetConsoleMsg(string msg)
        {
            base.consoleMsg = msg;
        }

        public void DBConnection(string connectionString)
        {
            base.dbConString = connectionString;
        }

        public override void displayConsoleMessage()
        {
            Console.Write(consoleMsg);//write this message to Database
        }

        public override void DBWrite()
        {
            //add code to write given message to database
        }
    }
}