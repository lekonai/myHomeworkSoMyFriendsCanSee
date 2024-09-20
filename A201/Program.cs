using System.Reflection.Metadata.Ecma335;

namespace A201;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string finalMap = "";
        int totalPop = 0;
        int infectedNum = 0;
        
        string[] continents = input.Split('X');
        Console.WriteLine(continents.Length);
        for (int i = 0; i < continents.Length; i++)
        {
            int currentPop = continents[i].Length;
            Console.WriteLine(continents[i] + " and it's length: " + currentPop);
            totalPop = totalPop + continents[i].Length;
            if (continents[i].Contains('1'))
            {
                infectedNum += currentPop;
                continents[i] = "";
                for (int j = 0; j < currentPop; j++)
                {
                    continents[i] = continents[i] + "1";
                }
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine("this is what the world will look like at the end of the month.");
        for (int i = 0; i < continents.Length; i++) // prints it all out... nice !
        {
            if (i == continents.Length - 1)
            {
                Console.Write(continents[i]);
            }
            else
            {
                Console.Write(continents[i] + "X");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("here's the total population: " + totalPop);
        Console.WriteLine("here's the amount that's going to get infected: " + infectedNum);
        float quickPercentage = infectedNum / (float)totalPop * 100;
        Console.WriteLine("percentage to get infected: " + quickPercentage);
        
    }
}