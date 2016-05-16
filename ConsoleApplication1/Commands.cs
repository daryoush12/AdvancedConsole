using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace AdvancedConsole
{
    public static class CommandMethods
    {

        //Functions for all console commands

        public static void help(string message)
        {
            // saved as a string value. ToDo: Fetch all commands from directorylist and save them into string.
            String CmdList = "help,readh,processinfo,randomisenumber";


            Util.consolemessage("You Have Current Commands: "+CmdList);
         
        }

        public static void connectdb(string message)
        {

            // Connect to any wanted database. Ask for credentials. Ip , username and password.

        }
        public static void readh(string message)
        {

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                
            // Display used storage.
                Console.WriteLine(drive.Name);
                if (drive.IsReady) Console.WriteLine(drive.TotalSize);
            }

            }
        public static void processinfo(string message) {
            //Lists all processes in pc at used moment.
            Process[] processCollection = Process.GetProcesses();
        Console.WriteLine("Currently Running Processes:\n");
        Thread.Sleep(300);
        foreach (Process p in processCollection)  
        {
            
            Console.WriteLine(p.ProcessName);
            Thread.Sleep(50);
        } 
 
        }

   
        public static void randomisenumber(string message)
        {

            //Used for testing randomising.
            Random rnd = new Random();
            int randomednumber = rnd.Next(1, 100);
            redo:
            Util.consolemessage("Guess the number(1-100):");
            string numberguess = Console.ReadLine(); // Get string from user
            int answer;
            bool isValid = int.TryParse(numberguess, out answer); // the out keyword allows the method to essentially "return" a second value
            if (isValid == false)
            {


                Util.consolemessage("Something went wrong!"+answer);
                goto redo;

            }
           

           else if(isValid == true) {

                if(answer == randomednumber)
                {
                    Util.consolemessage("Randomised number is:" + randomednumber + " You Guessed Right!");
                }

            }




        }




        


    
   }

        

  }
    

