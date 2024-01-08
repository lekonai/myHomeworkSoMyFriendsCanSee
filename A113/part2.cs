using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace A113
{
    public class part2
    {
        // globals
        static public int hScore = 0; 
        static public string hScorer = "";
        struct people // struct, i love structs.
        {
            public string id;
            public int score;
            public string date;
        }
        static public void theMain()
        {
            string filename = "A113HighScores.txt";
            string[] allTheText = File.ReadAllLines(filename);
            //for (int i = 0; i < allTheText.Length; i++) // checking if everything works
            //{
            //    Console.WriteLine(allTheText[i]);
            //}
            List<people> theListToRuleThemAll = new List<people>();
            for (int i = 0; i < allTheText.Length; i++)
            {
                string currentString = allTheText[i];
                string name = currentString.Substring(1,3); // getting the name
                //Console.Write(name + " ");
                string score = currentString.Substring(6, 6); // getting the score
                //Console.Write(score + " ");
                string date = currentString.Substring(13, 10);  // getting the date
                //Console.Write(date); // check if it works
                int scoreButInt = int.Parse(score);
                people thisPerson; // making the variable to add
                thisPerson.id = name;
                thisPerson.score = scoreButInt;
                thisPerson.date = date;
                theListToRuleThemAll.Add(thisPerson);
                //Console.WriteLine("");
            }
            findHS(theListToRuleThemAll);
            // Q1
            Console.WriteLine("The score is {0}, and the name is: {1}", hScore, hScorer); 
            // Q2
            Console.WriteLine("The highest score in 2019 was: {0}", coronaYear(theListToRuleThemAll)); 
            // Q3
            Console.WriteLine("BoB has played this game {0} times", bobFinder(theListToRuleThemAll)); 
            // Q4
            Console.WriteLine("The average for 2020 is {0}", twentyAVG(theListToRuleThemAll));
            // Q5
            Console.WriteLine("The highest score on 29/02 is {0}", leapDayFinder(theListToRuleThemAll));

        }
        static void findHS(List<people> usedList) // find the high score
        {
            for (int i = 0; i < usedList.Count; i++)
            {
                if (usedList[i].score > hScore)
                {
                    //Console.Write("F!"); // checker
                    hScore = usedList[i].score;
                    hScorer = usedList[i].id;
                }
                else
                {
                    //Console.Write("nf."); // checker
                }
            }
        }
        static int coronaYear(List<people> usingList) // find highest on 2019
        {
            int theYear = 2019;
            int hScore2019 = 0;
            for (int i = 0; i < usingList.Count; i++)
            {
                int usingYear = int.Parse(usingList[i].date.Substring(6, 4));
                if (usingYear == theYear)
                {
                    if (usingList[i].score > hScore2019)
                    {
                        hScore2019 = usingList[i].score;
                    }
                    else { }
                }
                else { }
            }

            return hScore2019;
        }
        static int bobFinder(List<people> usingList) // find bob
        {
            int bobCount = 0;
            for (int i =0; i < usingList.Count; i++) // same iteration again lol
            {
                string currentID = usingList[i].id;
                if (currentID == "BoB")
                {
                    bobCount++;
                }
                else { }
            }

            return bobCount;
        }
        static float twentyAVG(List<people> usingList) // fidn the averagfe of 2020
        {
            int sum = 0;
            int frequency = 0;
            for (int i = 0; i < usingList.Count; i++)
            {
                int usingYear = int.Parse(usingList[i].date.Substring(6, 4));
                if (usingYear == 2020)
                {
                    frequency++;
                    sum = sum + usingList[i].score;
                }
            }

            float averaged = sum / frequency;
            return averaged;

        }
        static int leapDayFinder(List<people> usingList) // find the highest score on the 29/2
        {
            int HS = 0;
            for (int i = 0; i < usingList.Count; i++)
            {
                int currentDay = int.Parse(usingList[i].date.Substring(0, 2));
                //Console.WriteLine(currentDay); // checker it's good !!
                if (currentDay == 29)
                {
                    int currentMonth = int.Parse(usingList[i].date.Substring(3,2));
                    if (currentMonth == 2)
                    {
                        int currentScore = usingList[i].score;
                        if (currentScore > HS)
                        {
                            HS = currentScore;
                        }
                        else { }
                    }
                    else { }
                }
                else { }
            }

            
            return HS;
        }
    }
}
