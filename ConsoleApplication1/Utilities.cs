using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;



namespace AdvancedConsole
{
   static class Util
    {

       


       //Methods for command processing
    

        public static void ReadCommand(){
           Console.Write("AdvancedConsole>");
           string command = Console.ReadLine(); // Get string from user
           ProcessCommand(command);
      
            
 

          }

        public static void AddCommands()
        {

            AdvancedConsole.CmdDictionary.Add("help", CommandMethods.help);
            AdvancedConsole.CmdDictionary.Add("readh", CommandMethods.readh);
            AdvancedConsole.CmdDictionary.Add("processinfo", CommandMethods.processinfo);
            
            

        }

        public static void ProcessCommand(string command)
        {

            Action<string> CommandToBeRun;
            if (!AdvancedConsole.CmdDictionary.TryGetValue(command.Split(' ')[0], out CommandToBeRun))
            {
                //Command not found, gives out error message
                Console.WriteLine("\nCommand was not recognised by AdvancedConsole.\n");

                return;
            }
            CommandToBeRun(command); //execute command
            // then return into default state


        }


        // Other utilities:

            //Configuring Console:
        public static void Configurate()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;


        }


        public static void consolemessage(string message)
        {


            Console.WriteLine("\nAdvancedConsole>"+message+"\n");


        }

        }



    }

