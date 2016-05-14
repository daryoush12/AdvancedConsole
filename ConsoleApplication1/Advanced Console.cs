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
    static class AdvancedConsole
    {
        public static Dictionary<string, Action<string>> CmdDictionary = new Dictionary<string, Action<string>>();
        public static void Main(string[] args)
        {
            // Our Program starts with checking the commands
            Util.AddCommands();
            Util.Configurate();
            // Program iniates and waits for Users Interaction
            Console.WriteLine("\nAdvancedConsole [Version 0.1.0001]\n");
            Console.WriteLine("Type help to see usable commands\n");
        Cmd:
            
            Util.ReadCommand();
            
            //This is bump act after every and each command.
            goto Cmd;


        }

    }
}
            

        
   

