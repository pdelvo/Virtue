using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Virtue
{
    public class Program
    {
        private class StartParameters
        {
            public StartParameters()
            {
                Configuration = "config.xml";
            }

            public bool RunSetup { get; set; }
            public string Configuration { get; set; }
        }

        public static void Main(string[] args)
        {
            // TODO: Load plugins here

            var parameters = new StartParameters();
            
            for (int i = 0; i < args.Length; i++) // TODO: Consider moving this out of this file
            {
                var arg = args[i];
                try
                {
                    if (arg.StartsWith("-"))
                    {
                        switch (arg)
                        {
                            case "--config":
                                parameters.Configuration = args[++i];
                                break;
                            case "--setup":
                                parameters.RunSetup = true;
                                break;
                            default:
                                Console.WriteLine("Invalid usage! Use Virtue.exe --help to get more information.");
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid usage! Use Virtue.exe --help to get more information.");
                        return;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid usage! Use Virtue.exe --help to get more information.");
                    return;
                }
            }

            if (!File.Exists(parameters.Configuration) || parameters.RunSetup)
                Setup.FirstTimeSetup();
        }
    }
}
