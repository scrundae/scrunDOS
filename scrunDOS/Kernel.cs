using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Sys = Cosmos.System;

namespace scrunDOS
{
    public class Kernel : Sys.Kernel
    {
        public string UserName = "USER";
        public string Input = "";
        public string SavedText;
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.Beep(37, 1);

            Console.WriteLine("Welcome to scrunDOS.");
            Console.WriteLine("What should I call you?");
            UserName = Console.ReadLine();
            Input = "p"; HandleCommands();
        }

        protected override void Run()
        {
            Input = Console.ReadLine();
            HandleCommands();
        }

        public void HandleCommands()
        {
            if (Input == "cls")
            {
                Console.Clear();
            }

            else if (Input == "p")
            {
                
                Console.Clear();
                Console.WriteLine("-SCRUNDOS : PORTAL : " + UserName.ToUpper() + "-");
                Console.WriteLine("Welcome to the Portal, " + UserName + "!");
                Console.WriteLine("You can access this menu if you are lost by entering 'P' into the console.");
                Console.WriteLine("You can also enter 'P' to refresh the Portal if it gets filled with commands.");
                Console.WriteLine("");
                Console.WriteLine("Commands & applets:");
                Console.WriteLine("");
                Console.WriteLine("cls - Clear screen");
                Console.WriteLine("inforep - System information");
                Console.WriteLine("str - Save text to RAM");
                Console.WriteLine("pfr - Print text stored in RAM");
                Console.WriteLine("rfr - Run text stored in RAM as if it were a command");
                Console.WriteLine("themer - Change themes for current session");
                Console.WriteLine("sesh - Change username for current session");
                Console.WriteLine("");
            }

            else if (Input == "inforep")
            {
                Console.WriteLine("You are currently running scrunDOS 1");
                Console.WriteLine("This product is provided for free of charge by scrundaegames.");
                Console.WriteLine("If you paid for this product, you got scammed and should demand");
                Console.WriteLine("your money back.");
            }

            else if (Input == "str")
            {
                Console.Clear();
                Console.WriteLine("-ACCESSORIES : SAVE TO RAM-");
                Console.WriteLine("Enter text to save to RAM...");
                SavedText = Console.ReadLine();
                if (SavedText == "rfr")
                {
                    Console.WriteLine("This may cause a system halt later. Proceed? (y = yes)");
                    string si = Console.ReadLine();
                    if (si == "y")
                    {

                    }
                    else
                    {
                        SavedText = "";
                    }
                }
                else
                {

                }
                Input = "p"; HandleCommands();
            }

            else if (Input == "pfr")
            {
                Console.WriteLine(SavedText);
            }

            else if (Input == "rfr")
            {
                Input = SavedText;
                HandleCommands();
            }

            else if (Input == "themer")
            {
                Console.Clear();
                Console.WriteLine("-CONTROL PANEL : SESSION THEME-");
                Console.WriteLine("");
                Console.WriteLine("Possible themes:");
                Console.WriteLine("red");
                Console.WriteLine("green");
                Console.WriteLine("blue");
                Console.WriteLine("basic");
                Console.WriteLine("classic");
                Console.WriteLine("sterile");
                Console.WriteLine("wi");
                Console.WriteLine("");
                string mti = Console.ReadLine();
                if (mti == "blue")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Input = "p"; HandleCommands();
                }
                if (mti == "red")
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Input = "p"; HandleCommands();
                }
                if (mti == "green")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Input = "p"; HandleCommands();
                }
                if (mti == "basic")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Input = "p"; HandleCommands();
                }
                if (mti == "classic")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Input = "p"; HandleCommands();
                }
                if (mti == "sterile")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Input = "p"; HandleCommands();
                }
                if (mti == "wi")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Input = "p"; HandleCommands();
                }
            }

            else if (Input == "sesh")
            {
                Console.Clear();
                Console.WriteLine("-CONTROL PANEL : CHANGE USERNAME-");
                UserName = Console.ReadLine();
                Input = "p"; HandleCommands();
            }

            else if (Input == "shutdown")
            {
                Sys.Power.Shutdown();
            }

            else if (Input == "reboot")
            {
                Sys.Power.Reboot();
            }

            else
            {
                Console.WriteLine("Unknown command.");
            }
        }
    }
}
