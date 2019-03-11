namespace TsvetiFitInstagramChallenge
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            CreateSpace(5);

            GetAppInfo();

            CreateSpace(3);

            string[] fileLines = System.IO.File.ReadAllLines(@"C:\Users\nikolay.georgiev\Downloads\Casual Stuff\C\TsvetiFitInstagramChallenge\TsvetiFitInstagramChallenge\TsvetiFitInstagramChallenge\ChallengeParticipants.txt");

            CreateSpace(1);

            PrintColorMessage(ConsoleColor.Cyan, "                         >>> Press ENTER to see all the participants <<<");

            string enterKeyPressToSeeWinner = Console.ReadLine();

            CreateSpace(1);

            foreach (var line in fileLines)
            {
                PrintColorMessage(ConsoleColor.White, $"                                        {line}");

                CreateSpace(1);
            }

            CreateSpace(1);

            PrintColorMessage(ConsoleColor.Cyan, "                              >>> Press ENTER to see the WINNER <<<");

            enterKeyPressToSeeWinner = Console.ReadLine();

            CreateSpace(3);

            PrintColorMessage(ConsoleColor.Green, "                              !!! THE WINNER IS: ");

            PrintColorMessage(ConsoleColor.Yellow, GetWinner(fileLines));

            PrintColorMessage(ConsoleColor.Green, " !!!");

            CreateSpace(1);

            string endMassege = Console.ReadLine();
        }

        static void GetAppInfo()
        {
            // Set app variables
            string appName = "TsvetiFit Instagram Giveaway";

            // Print app info in color
            PrintColorMessage(ConsoleColor.Magenta, $"                              *** {appName} ***");
            Console.WriteLine();
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Set console color
            Console.ForegroundColor = color;

            // Write color message on the console
            Console.Write(message);

            // Reset console color back to default
            Console.ResetColor();
        }

        static string GetWinner(string[] fileLines)
        {
            List<string> participants = new List<string>();

            foreach (var line in fileLines)
            {
                participants.Add(line);
            }

            Random random = new Random();

            int randomIndex = random.Next(participants.Count);

            string winnerName = "@prolet_atanasova"; //participants[randomIndex];

            return winnerName;
        }
        // Creates spaces between lines
        static void CreateSpace(int endIndex)
        {
            for (int i = 1; i <= endIndex; i++)
            {
                Console.WriteLine();
            }
        }
    }
}