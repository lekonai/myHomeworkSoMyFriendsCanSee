using System.Runtime.CompilerServices;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace A223;

class Program
{
    static void Main(string[] args)
    {
        int highest = 0;
        List<string> currList = listOfConsonantSubstring("hufflepuff");
        foreach (string v in currList)
        {
            Console.WriteLine("the substring is {0}, and the value of this is: {1}", v, highestValueConsonantSubstring(v));
            if (highest < highestValueConsonantSubstring(v))
            {
                highest = highestValueConsonantSubstring(v);
            }
        }

        Console.WriteLine("that would make the highest substring have a value of {0}", highest);
    }

    static List<string> listOfConsonantSubstring(string str)
    {
        List<string> subStrL = new List<string>();
        string tempString = "";
        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i]) // bit finnicky in comparison to what i would've tried out (regex), but it is what the question asks for, and i can't deviate from that
            {
                case 'a':
                    subStrL.Add(tempString);
                    tempString = "";
                    break;
                case 'e':
                    subStrL.Add(tempString);
                    tempString = "";
                    break;
                case 'i':
                    subStrL.Add(tempString);
                    tempString = "";
                    break;
                case 'o':
                    subStrL.Add(tempString);
                    tempString = "";
                    break;
                case 'u':
                    subStrL.Add(tempString);
                    tempString = "";
                    break;
                default:
                    tempString += str[i];
                    break;
            }
        }
        subStrL.Add(tempString);
        return subStrL;
    }

    static int highestValueConsonantSubstring(string st)
    {
        int substringT = 0;
        for (int j = 0; j < st.Length; j++)
        {
            substringT += st[j] - 96;
        }
        return substringT;
    }






    static string GetMiddle(string str)
    {
        if (str.Length == 0)
        {
            return "";
        }
        if (str.Length % 2 == 0)
        {
            // even
            string evenString = str[(str.Length / 2) - 1].ToString() + str[str.Length / 2];
            return evenString;
        }
        if (str.Length % 2 == 1)
        {
            // odd
            return str[str.Length / 2].ToString();
        }
        return "";
    }
    
}