using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace A109
{
    class Program
    {
        static public int totalscore = 27;
        static void Main(string[] args)
        {
            bool goingThroughTheProgram = true;
            while (goingThroughTheProgram == true)
            {
                
                

                Console.WriteLine("Welcome to the DnD stats thing");
                int amountOfStats = 6;
                Console.WriteLine("How many stats would you like to enter?");
                int howManyS = int.Parse(Console.ReadLine());
                bool statsNoValidator = false;
                while (statsNoValidator == false)
                {
                    if (howManyS > 0)
                    {
                        amountOfStats = howManyS;
                        statsNoValidator = true;
                    }
                    else if (howManyS < 0)
                    {
                        Console.WriteLine("That doesn't work.");
                        statsNoValidator = false;
                        //Console.WriteLine("Out of spite, goodbye"); // the context for this one is that I tried making a while loop but there's too many local variables within it and i'm not enjoying it.
                        //Thread.Sleep(5000);
                        //Environment.Exit(0);
                    }
                }


                string[] stats = new string[amountOfStats];
                int[] scores = new int[amountOfStats];
                Console.WriteLine("The size of stats is now: {0}", stats.Length);
                Console.WriteLine("The size of scores is now: {0}", scores.Length);

                Console.WriteLine("Cool!"); // just to tell me that we're at another part

                Console.WriteLine("Time for stat name selection (if you want default DND stats, input these: Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma)"); // stat name selector
                for (int i = 0; i < amountOfStats; i++)
                {
                    Console.WriteLine("Enter the name:");
                    stats[i] = Console.ReadLine();
                    Console.WriteLine("Stat {0} is now called {1}", i + 1, stats[i]);
                }

                foreach (string i in stats)
                {
                    Console.WriteLine($"{i}");
                }

                Console.WriteLine("Enter your total score to tally up after (DnD standard is 27):");
                totalscore = int.Parse(Console.ReadLine());


                Console.WriteLine();

                int j = 0;
                for (int i = 0; i < stats.Length; i++)
                {
                    bool inpValidation = false;
                    while (inpValidation == false)
                    {
                        Console.WriteLine("Enter a stat for {0} between 8 and 15", stats[i]);
                        int inputter = int.Parse(Console.ReadLine());
                        if (inputter >= 8 && inputter <= 15)
                        {
                            scores[j] = inputter;
                            j++;
                            inpValidation = true;
                        }
                        else
                        {
                            inpValidation = false;
                            Console.WriteLine("No! Between 8 and 15 please, including those numbers :)");
                        }
                    }
                    Console.WriteLine("Next stat...");
                    inpValidation = false;
                }
                Console.WriteLine("\nHere are the stats:");
                for (int ji = 0; ji < stats.Length; ji++)
                {
                    Console.WriteLine("{0}: {1}", stats[ji], scores[ji]);
                }

                checkStats(scores, amountOfStats);
                Console.WriteLine("Do you want to run the program again? y/n");
                ConsoleKeyInfo inp1 = Console.ReadKey();
                if (inp1.Key == ConsoleKey.Y)
                {
                    goingThroughTheProgram = true;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("\nBye Bye.");
                    goingThroughTheProgram = false;
                }
            }
            
            Console.ReadKey(); Console.ReadKey();
        }

        static void checkStats(int[] scores, int amountOfStats)
        {
            int tallyUp = 0;
            for (int i = 0; i < amountOfStats; i++)
            {
                if (scores[i] == 8)
                {
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 9)
                {
                    tallyUp++;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 10)
                {
                    tallyUp += 2;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 11)
                {
                    tallyUp += 3;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 12)
                {
                    tallyUp += 4;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 13)
                {
                    tallyUp += 5;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 14)
                {
                    tallyUp += 7;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
                else if (scores[i] == 15)
                {
                    tallyUp += 9;
                    // Console.WriteLine("Points total is: {0}", tallyUp);
                }
            }
            if (tallyUp == totalscore)
            {
                Console.WriteLine("These stats are valid, they are equal to {0}", totalscore);
            }
            else
            {
                Console.WriteLine("These stats are not valid.");
                Console.WriteLine("Score is {0}, they must be equal to {1}", tallyUp, totalscore);
            }
        }
    }
}
