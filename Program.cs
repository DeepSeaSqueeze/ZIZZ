using System;
using System.IO;
using System.Threading;

namespace ZizzCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 39;
            Console.WindowWidth = 100;

            //Set new random thingy
            Random rd = new Random();

            //Set Attempts made variable
            int ATT = 0;

            //Set Key Count Variable
            int KEYCOUNT = 0;

            //Set Desired Number of Keys Variables
            string USR;
            int KEYNUM = 0;

            //Display ASCII Zizz
            Thread.Sleep(100);
            Console.Write
            (
                "                           ```.....................````                                        \n" +
                "                       `.....````                ````.....`    `.............`                 \n" +
                "                   ``...``                             ``.......--:::::::::---..``             \n" +
                "                `...``                                     ``..-::::::::::::::::-..`           \n" +
                "              `..`                                            `..-::::::::::::::::..`          \n" +
                "            `.``                                                 `.-::::::::::::::-.`          \n" +
                "          `.`                                                      `.-:::::::-.....`           \n" +
                "         ...`                                                        `.-::::::-.`              \n" +
                "          `...`                                                       `..-:::::-.`             \n" +
                "             `..``                                                      `.-:::::-.`            \n" +
                "               ``..`                                                     `.-:::::..            \n" +
                "                     ``.``     `````......``.`````                     ``.-::::::..            \n" +
                "                        `..`.-/+syhhdmmNNm.+ddpieso/:.``            `..-::::::---..`.-.`       \n" +
                "                   ``....../dEEPSEASQUEEZe.dmmmmnekookto/.``     `..-::::::::::....:ddy.`      \n" +
                "    Z I Z Z:      `.-ymds.:NYUMRy:.:dMMMM+-mmfunnylandmmmmy/..`.--:::::::::::--::/+/++//+/:..``\n" +
                "                  ..+mmms.hMMMMs`  `:MMMM-/mmmmmmmmhso/+hmmmh.-:::::::::::---/+oossssoossooo/:.\n" +
                "      A           `.+mmm/-MMMMN-    .NMMm.ommmmmms:.`  .ymmmd.-:::::::::::.shhhhhhhhhhhhhhhhdy.\n" +
                "   K E Y G E N     .-smN::MMMMd.   `-MMMy.ymmmmh:`   `-smmmmd:oyy+--::::::./ssssyyyyyyyyysss+-.\n" +
                "        F O R       `.:o-:MMMMm.`  .yMMMs.hmmmm:`  `-+dmmmmmmmmmmm+.:::::::-mmdhdddysshddmmNd.`\n" +
                "V O C A L             `...mMMMMy-`.oMMMMo.mmmmmhsooydmmmmmmmmmmmmd:-:::::::-Md//+y+////mmNmmN..\n" +
                "        W R I T E R     `.+MMMMMmddMMMMM+-mmmmmmmmmmmmmmmmmmhhhyo::::::::::.md-//::///omNMNmN-.\n" +
                "                         `.oNMMMMMMMMMMM/:mmmmmdymmmmmmmmmd/---:::::::::--:-hmo:///:::dmmdddN/.\n" +
                "                          `.:hNMMMMMMMMM:-///:::ymmmmmmmms-:::::::::::::-.-.yNmy//--:-sh+/:sN+.\n" +
                "                            `.:odNMMMMMM:...-/sdmmmmmmdo:-::::::::::::::-...oNmmds:-/:-:::-yNo.\n" +
                "                              ```-/shmNN-smmmmmmmmdyo/--::::::::::::::..-.../MmmNmm+:/::::ymNy.\n" +
                "                                  ```.-:.://+///:----:::::::::::::::::..`.-.-MNmNMMm+:::sdmmMh.\n" +
                "                                     ..`````````-:------..-:::::::-:::.` .ss.dMNNNmmm+smmhyyy+.\n" +
                "                          ````````......:oyhddmmmddhy-`   .:::::::.-::.` .+my-/ossssssssyhys+-.\n" +
                "                   ``......`````     `:hMMMMMMMMMMMN/`   `.:::-::-..--.  `-mmddohmmmmmy+:..... \n" +
                "                   `..`            `-yNMMMMMMMMMMMMoydy+:.-::..-:-.`````...ommsmmmmyo-..`````` \n" +
                "                    `..           `-osssmMMMNhsydNd:NMMMNm--.``..`    `.+ss++oshho-..````````` \n" +
                "                     `..`          `.+hd+dMm+sddhyymNmNNm/`..`      `.:yhdddhhyo:..``````````` \n" +
                "                      `..        .+ymMMMMMNMMMMMMMm.  `.`    `..``..``.:oyhdddddddh/..         \n" +
                "  Build Date:         `.`           .oNMMMmyosdNNN+`   `.      `..`     `.:shddhys/-..`        \n" +
                " August 15, 2021     `.`       `.`   `:os/.  `.-:-`     .`       `         `-/o/-.```````````` \n" +
                "                    `.`        ...                 `-.  `.                 `...``              \n" +
                "                   `.`        ....`      `:.       .o/`  ..              `...````````````````` \n"
            );
            Thread.Sleep(500);
            Console.Beep(392, 250);
            Console.Beep(523, 250);
            Console.Beep(392, 250);
            Console.Beep(659, 250);
            Thread.Sleep(500);
            Console.Beep(392, 250);
            Console.Beep(659, 250);
            Console.Beep(523, 250);
            Console.Beep(783, 250);
            Console.SetCursorPosition(Console.CursorLeft+3, Console.CursorTop-11);
            Console.Write("[PRESS ENTER]");
            Console.SetCursorPosition(Console.CursorLeft-13, Console.CursorTop);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop+11);
            //Wait for input
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }
            Console.Clear();

            //Display Intro Prompt
            Console.WriteLine(
           "************************************\n" +
           "* #######                          *　　　　\"Because of my love for you,\n" +
           "*      #     #    ######    ###### *　　　　　Your beautiful singing voice is in my hands!\"\n" +
           "*     #      #        #         #  *\n" +
           "*    #       #       #         #   *\n" +
           "*   #        #      #         #    *\n" +
           "*  #         #     #         #     *\n" +
           "* #######    #    ######    ###### *\n" +
           "************************************\n" +
           "------------------------------------\n");

            Console.WriteLine(
                "VocalWriter 1.0/2.0 Keygen by DeepSeaSqueeze, NekoOkto and Yumry\n" +
                "\n" +
                "1.0 Cracked by DeepSeaSqueeze\n2.0 Cracked by DeepSeaSqueeze and NekoOkto\n" +
                "\n" + "Keygen Programming - DeepSeaSqueeze\n" + "\nGitHub: https://github.com/DeepSeaSqueeze/ZIZZ \n\nLicensed under the GNU General Public License v3.0" +
                "\n------------------------------------\n");			

            Console.WriteLine(
            "Please specify your version with the number keys:\n" +
            "\n" +
            "     1. VocalWriter 1.0 for MacOS Classic\n" +
            "     2. VocalWriter 2.0 for OSX");
			//User inputs their version of VocalWriter
            while (true)
            {
                ConsoleKeyInfo version = Console.ReadKey();
                if (version.KeyChar == '1')
                {
                    //Generate 1.0 Key            

                    //Set array for the V1.0 keygen
                    int[] KEY = new int[9];

                    Console.Clear();
                    Console.WriteLine("\n How many serial numbers do you want? (MAX: 10)");

                    //Read input from user & convert to integer
                    USR = Console.ReadLine();
                    KEYNUM = Convert.ToInt32(USR);

                    //Keygen Code for 1.0
                    Console.Clear();
                    Console.Write("VocalWriter 1.0 Serial Number: \n" + "\n");

                    while (KEYCOUNT < KEYNUM)
                    {
                        KEY[0] = 0;
                        KEY[1] = 0;
                        KEY[2] = 0;
                        KEY[3] = 0;
                        KEY[4] = 0;
                        //Hardcode KEY[5] as 7
                        KEY[5] = 7;
                        KEY[6] = 0;
                        KEY[7] = 0;
                        KEY[8] = 0;

                        //Generate random numbers until the sum of the whole key is 39
                        while (KEY[0] + KEY[1] + KEY[2] + KEY[3] + KEY[4] + KEY[5] + KEY[6] + KEY[7] + KEY[8] != 39)
                        {
                            KEY[0] = rd.Next(0, 9);
                            KEY[1] = rd.Next(0, 9);
                            KEY[2] = rd.Next(0, 9);
                            KEY[3] = rd.Next(0, 9);
                            KEY[4] = rd.Next(0, 9);
                            //KEY[5] = 7;
                            KEY[6] = rd.Next(0, 9);
                            KEY[7] = rd.Next(0, 9);
                            KEY[8] = rd.Next(0, 9);

                            //Add to attempt count
                            ATT++;
                        }

                        //Add to key count
                        KEYCOUNT++;

                        //Spit the key out to the console
                        Console.Write(KEY[0]);
                        Console.Write(KEY[1]);
                        Console.Write(KEY[2]);
                        Console.Write("-");
                        Console.Write(KEY[3]);
                        Console.Write(KEY[4]);
                        Console.Write(KEY[5]);
                        Console.Write("-");
                        Console.Write(KEY[6]);
                        Console.Write(KEY[7]);
                        Console.Write(KEY[8]);

                        Console.Write("\n");
                    }

                    //Failed atttempts variable
                    int FATT = ATT - KEYCOUNT;

                    //Spit out info
                    //Console.Write("\n" + "\n" + "Total Failed Attempts: " + FATT);
                    Console.Write("\n" + "\n" + "Total Keys Generated: " + KEYCOUNT);
                    Console.WriteLine("\n" + "\n" + "Press \"Enter\" to Exit");
                    
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {

                    }
					
					//Easter Egg
                    if (KEYNUM > 10)
                    {
                        Console.Clear();
                        Console.Write("It's not a bug...It's a feature! But limits are set for a reason. (´･ ω ･`)\n \nUse my favorite code: 420-697-573\n" +
                            "                                            ~ DeepSeaSqueeze\n \n");
                        Console.Write("Press \"Enter\" to exit for real this time. I promise.");
						
						//Wait for input
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {

                        }

                        break;
                    }

                    break;
                }

                else if (version.KeyChar == '2')
                {
                    //Generate 2.0 Key            

                    //Set array for the V2.0 keygen
                    int[] KEY = new int[12];

                    Console.Clear();
                    Console.WriteLine("\n How many serial numbers do you want? (MAX: 10)");

                    //Read input from user & convert to integer
                    USR = Console.ReadLine();
                    KEYNUM = Convert.ToInt32(USR);

                    //Keygen Code for 2.0
                    Console.Clear();
                    Console.Write("VocalWriter 2.0 Serial Number: \n" + "\n");

                    while (KEYCOUNT < KEYNUM)
                    {
                        KEY[0] = 0;
                        KEY[1] = 0;
                        KEY[2] = 0;
                        KEY[3] = 0;
                        KEY[4] = 0;
                        KEY[5] = 0;
                        KEY[6] = 0;
                        KEY[7] = 0;
                        //Hardcode KEY[8] as 1
                        KEY[8] = 1;
                        KEY[9] = 0;
                        KEY[10] = 0;
                        KEY[11] = 0;

                        //Generate random numbers until the sum of the whole key is 61
                        while (KEY[0] + KEY[1] + KEY[2] + KEY[3] + KEY[4] + KEY[5] + KEY[6] + KEY[7] + KEY[8] + KEY[9] + KEY[10] + KEY[11]!= 61)
                        {
                            KEY[0] = rd.Next(0, 9);
                            KEY[1] = rd.Next(0, 9);
                            KEY[2] = rd.Next(0, 9);
                            KEY[3] = rd.Next(0, 9);
                            KEY[4] = rd.Next(0, 9);
                            KEY[5] = rd.Next(0, 9);
                            KEY[6] = rd.Next(0, 9);
                            KEY[7] = rd.Next(0, 9);
                            //KEY[8] = 1;
                            KEY[9] = rd.Next(0, 9);
                            KEY[10] = rd.Next(0, 9);
                            KEY[11] = rd.Next(0, 9);

                            //Add to attempt count
                            ATT++;
                        }

                        //Add to key count
                        KEYCOUNT++;

                        //Spit the key out to the console
                        Console.Write(KEY[0]);
                        Console.Write(KEY[1]);
                        Console.Write(KEY[2]);
                        Console.Write("-");
                        Console.Write(KEY[3]);
                        Console.Write(KEY[4]);
                        Console.Write(KEY[5]);
                        Console.Write("-");
                        Console.Write(KEY[6]);
                        Console.Write(KEY[7]);
                        Console.Write(KEY[8]);
                        Console.Write("-");
                        Console.Write(KEY[9]);
                        Console.Write(KEY[10]);
                        Console.Write(KEY[11]);

                        Console.Write("\n");
                    }

                    //Failed atttempts variable
                    int FATT = ATT - KEYCOUNT;

                    //Spit out info
                    //Console.Write("\n" + "\n" + "Total Failed Attempts: " + FATT);
                    Console.Write("\n" + "\n" + "Total Keys Generated: " + KEYCOUNT);
                    Console.WriteLine("\n" + "\n" + "Press \"Enter\" to Exit");

                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {

                    }


                    if (KEYNUM > 10)
                    {
                        Console.Clear();
                        Console.Write("It's not a bug...It's a feature! -w-" +
                            "\n \nHere, use my favorite key! 666-666-661-660\n                                            ~ NekoOkto \n \n");
                        Console.Write("Press \"Enter\" to exit for real this time. I promise.");

                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        {

                        }

                        break;
                    }

                    break;
                }
                
				Environment.Exit(0);
            }
        }
    }
}