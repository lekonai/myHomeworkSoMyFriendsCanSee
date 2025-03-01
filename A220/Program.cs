namespace A220;

class Program
{
    static void Main(string[] args)
    {
        string[,] words = {{"like", "a", "the", "what", "for", "world", "whale", "one", "last" },
            {"ocean", "beauty", "tweet", "monster", "yellow", "return", "despair", "flower", "return"},
            {"romantic", "curious", "banana", "jealousy", "tactlessly", "remorseful", "follower", "elephant", "however" },
            { "salmonella", "consequently", "irregular", "intelligence", "vegetable", "ordinary", "alternative", "watermelon", "controversial"},
            {"lackadaisical", "serendipity", "colonoscopy", "dramatically", "parsimonious", "imagination", "electricity", "diabolical", "deforestation"},
            {"extraterrestrial", "onomatopoeia", "responsibility", "revolutionary", "generalisation", "enthusiastically", "biodiversity", "veterinarian", "characteristically"},
            {"oversimplification", "individuality", "decriminalisation", "compartmentalisation", "anaesthesiologist", "industrialisation", "buckminsterfullerene", "irresponsibility", "autobiographical"}};
        // string[] sent1 = { "46", "11" };
        // string[] sent2 = { "25", "21", "35"};
        // string[] sent3 = { "42", "14" };
        // if (HaikuChecker(words, sent1, sent2, sent3))
        // {
        //     Console.WriteLine("It's a Haiku");
        // }
        // else
        // {
        //     Console.WriteLine("Not a Haiku");
        // }
        HaikuGenerator(words);
        Console.WriteLine();
        HaikuGenerator(words);
    }

    static bool HaikuChecker(string[,] dict, string[] s1, string[] s2, string[] s3) // im sure there's a more concise way of doing this. not like i'd know
    {
        // okay sorry, why are the words not zero indexed. damn.
        int totalSyl1 = HaikuSentenceProcessor(dict, s1);
        int totalSyl2 = HaikuSentenceProcessor(dict, s2);
        int totalSyl3 = HaikuSentenceProcessor(dict, s3);
        if (totalSyl1 == 5 && totalSyl2 == 7 && totalSyl3 == 5)
        {
            return true;
        }
        return false;
    }

    static void HaikuGenerator(string[,] dict)
    {
        int maxSyl = 5;
        for (int i = 0; i < 3; i++)
        {
            string[] curSent = {"", "", "", "", "", "", ""}; // 7 is max
            if (i == 1)
            {
                maxSyl = 7;
            }
            if (i == 2)
            {
                maxSyl = 5;
            }

            Random randy = new Random();
            int count = 0;
            while (maxSyl > 1)
            {
                // remember to increment.
                // this is so much harder because of how awfully the original question is formatted. why isn't it 0 indexed? 
                int initVal = randy.Next(0, maxSyl);
                int secVal = randy.Next(0, 8) + 1;
                string sentence = (initVal + 1).ToString() + secVal;
                maxSyl -= initVal + 1;
                curSent[count] = sentence;
                // Console.WriteLine(curSent[count]); // debugging KEEP
                // Console.WriteLine("{0}", maxSyl); // debugging
                if (maxSyl == 1)
                {
                    curSent[count + 1] = 1.ToString() + (randy.Next(0, 8) + 1);
                    // Console.WriteLine(curSent[count + 1]); // debugging 
                }

                count++;
            }
            HaikuSentenceProcessor(dict, curSent);
        }
        

    }
    static int HaikuSentenceProcessor(string[,] dict, string[] s)
    {
        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "")
            {
                
            }
            else
            {
                int firstNum = s[i][0] - 48;
                int secondNum = s[i][1] - 48;
                Console.Write(dict[firstNum - 1,secondNum - 1] + " ");
                total += firstNum;
            }
            
        }
        Console.WriteLine();
        return total;
    }
}