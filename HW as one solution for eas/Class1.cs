using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A109
{
    class Class1
    {
        static public void fruitsaladyummyummy()
        {
            // left over code.
            bool goingThroughTheProgram = true;
            while (goingThroughTheProgram == true)
            {

                //Console.WriteLine("Welcome to the DND stats thing");
                //Console.WriteLine("How many stats would you like to enter?");
                //int howMany = int.Parse(Console.ReadLine());

                string[] stats = new string[6] { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
                int[] scores = new int[6] { 0, 0, 0, 0, 0, 0 };
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

                checkStats(scores);
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

        static public void checkStats(int[] scores)
        {
            int tallyUp = 0;
            for (int i = 0; i < scores.Length; i++)
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
            if (tallyUp == 27)
            {
                Console.WriteLine("These stats are valid, because the score is equal to {0}", 27);
            }
            else
            {
                Console.WriteLine("These stats are not valid.");
                Console.WriteLine("Score is {0}, they must be equal to {1}", tallyUp, 27);
            }
        }
    }
}
