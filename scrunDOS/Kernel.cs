using Cosmos.Core.IOGroup;
using Cosmos.System.Graphics;
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
        public string UserName = "user";
        public string Input = "";
        public string SavedText;
        public Canvas canvas;
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Clear();

            Console.WriteLine("Welcome to scrunDOS.");
            Console.WriteLine("What should I call you?");
            UserName = Console.ReadLine();
            if (UserName == ";")
            {
                UserName = "user";
                Console.BackgroundColor = ConsoleColor.Black; 
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear(); Console.WriteLine("Ignoring user setup and launching terminal...");
            }
            else
            {
                Input = "p"; HandleCommands();
            }
        }

        protected override void Run()
        {
            Input = Console.ReadLine();
            HandleCommands();
        }

        public void HandlePortal()
        {
            Console.Clear();
            Console.WriteLine("-SCRUNDOS : PORTAL : " + UserName.ToUpper() + "-");
            Console.WriteLine(new String('-', Console.WindowWidth - 1));
            Console.WriteLine("Welcome to the Portal, " + UserName + "!");
            Console.WriteLine("You can exit the terminal by typing 'p' into the console.");
            Console.WriteLine("");
            Console.WriteLine("Directories:");
            Console.WriteLine("+ Accessories");
            Console.WriteLine("+ Control Panel");
            Console.WriteLine("+ System Tools");
            Console.WriteLine("");
            Console.WriteLine("Type the name of the directory you want to access, then hit enter.");
            Console.WriteLine("");
            string pi = Console.ReadLine();
            if (pi == "Accessories")
            {
                HandleAccessories();
            }
            else if (pi == "Control Panel")
            {
                HandleControl();
            }
            else if (pi == "System Tools")
            {
                HandleSystemTools();
            }
            else if (pi == "lock")
            {
                Console.WriteLine("Enter a passphrase:");
                string pass = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("-THIS SYSTEM HAS BEEN LOCKED-");
                Console.WriteLine(new String('-', Console.WindowWidth - 1));
                Console.WriteLine("Please enter the unlock passphrase. You have 2 attempts");
                string gpass = Console.ReadLine();
                if (gpass == pass)
                {
                    HandlePortal();
                }
                else
                {
                    Console.WriteLine("Incorrect guess. You have 1 attempt remaining.");
                    gpass = Console.ReadLine();
                    if (gpass == pass)
                    {
                        HandlePortal();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect guess. You have no attempts remaining.");
                        Console.WriteLine("The system will now be disabled for 10 minutes.");
                        System.Threading.Thread.Sleep(600000);
                        Console.WriteLine("The system has been re-enabled.");
                    }
                }
            }
            else
            {
                HandlePortal();
            }
        }

        public void HandleAccessories()
        {
            Console.Clear();
            Console.WriteLine("-SCRUNDOS : PORTAL : " + UserName.ToUpper() + "-");
            Console.WriteLine(new String('-', Console.WindowWidth - 1));
            Console.WriteLine("You are in a directory, " + UserName + ".");
            Console.WriteLine("To go back to the portal, enter 'back' into the console.");
            Console.WriteLine("");
            Console.WriteLine("Directories:");
            Console.WriteLine("- Accessories");
            Console.WriteLine("str");
            Console.WriteLine("+ Control Panel");
            Console.WriteLine("+ System Tools");
            Console.WriteLine("");
            Console.WriteLine("Type the name of the applet you want to access, then hit enter.");
            Console.WriteLine("");
            string pia = Console.ReadLine();
            if (pia == "str")
            {
                Input = "str";
                HandleCommands();
            }
            else if (pia == "back")
            {
                HandlePortal();
            }
            else
            {
                HandleAccessories();
            }
        }
        public void HandleControl()
        {
            Console.Clear();
            Console.WriteLine("-SCRUNDOS : PORTAL : " + UserName.ToUpper() + "-");
            Console.WriteLine(new String('-', Console.WindowWidth - 1));
            Console.WriteLine("You are in a directory, " + UserName + ".");
            Console.WriteLine("To go back to the portal, enter 'back' into the console.");
            Console.WriteLine("");
            Console.WriteLine("Directories:");
            Console.WriteLine("+ Accessories");
            Console.WriteLine("- Control Panel");
            Console.WriteLine("themer");
            Console.WriteLine("sesh");
            Console.WriteLine("+ System Tools");
            Console.WriteLine("");
            Console.WriteLine("Type the name of the applet you want to access, then hit enter.");
            Console.WriteLine("");
            string picp = Console.ReadLine();
            if (picp == "themer")
            {
                Input = "themer";
                HandleCommands();
            }
            else if (picp == "sesh")
            {
                Input = "sesh";
                HandleCommands();
            }
            else if (picp == "back")
            {
                HandlePortal();
            }
            else
            {
                HandleControl();
            }

        }
        public void HandleSystemTools()
        {
            Console.Clear();
            Console.WriteLine("-SCRUNDOS : PORTAL : " + UserName.ToUpper() + "-");
            Console.WriteLine(new String('-', Console.WindowWidth - 1));
            Console.WriteLine("You are in a directory, " + UserName + ".");
            Console.WriteLine("To go back to the portal, enter 'back' into the console.");
            Console.WriteLine("");
            Console.WriteLine("Directories:");
            Console.WriteLine("+ Accessories");
            Console.WriteLine("+ Control Panel");
            Console.WriteLine("- System Tools");
            Console.WriteLine("term");
            Console.WriteLine("");
            Console.WriteLine("Type the name of the applet you want to access, then hit enter.");
            Console.WriteLine("");
            string pist = Console.ReadLine();
            if (pist == "term")
            {
                Input = "cls";
                HandleCommands();
            }
            else if (pist == "back")
            {
                HandlePortal();
            }
            else
            {
                HandleSystemTools();
            }
        }

        public void HandleCommands()
        {
            if (Input == "cls")
            {
                Console.Clear();
            }

            else if (Input == "p")
            {
                HandlePortal();
            }

            else if (Input == "inforep")
            {
                Console.WriteLine("You are currently running scrunDOS 2");
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
            else if (Input == "add")
            {
                
            }
            else
            {
                Console.WriteLine("Unknown command.");
            }
        }
    }
}