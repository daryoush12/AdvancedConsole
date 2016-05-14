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

            String CmdList = "help,kac,ban,kick,warn and rules.";

            Util.consolemessage("You Have Current Commands: "+CmdList);
         
        }

        public static void kac(string message)
        {
            Console.WriteLine("\nWe are sending you to KaC's Website! \nPlease Wait..\n");
            System.Diagnostics.Process.Start("www.knifeassassins.com");

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
                //There are more attributes you can use.
                //Check the MSDN link for a complete example.
                Console.WriteLine(drive.Name);
                if (drive.IsReady) Console.WriteLine(drive.TotalSize);
            }

            }
        public static void processinfo(string message) {
 
        Process[] processCollection = Process.GetProcesses();
        Console.WriteLine("Currently Running Processes:\n");
        Thread.Sleep(300);
        foreach (Process p in processCollection)  
        {
            
            Console.WriteLine(p.ProcessName);
            Thread.Sleep(50);
        } 
 
        }



        public static void randomisenumber()
        {


            Random rnd = new Random();
            int randomednumber = rnd.Next(1, 100);
            string numberguess = Console.ReadLine(); // Get string from user
            Util.consolemessage("Randomised number is:" + randomednumber);



        }




        


    
   }

        

  }
    

