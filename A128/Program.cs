using System.Runtime.CompilerServices;

namespace A128;

class Program
{
    static void Main(string[] args)
    {
        // char[] chars = new char[50];
        string sentence = Console.ReadLine(); // 
        // char[] sentArray = sentence.ToCharArray();
        // List<char> listSent = new List<char>();
        // for (int i = 0; i < sentence.Length; i++)
        // {
        //     listSent.Add(sentArray[i]); // lists over arrays any day.
        // }
        // string tempString = "";
        // int temp;
        // int j = 0;
        // do
        // {
        //     if (listSent[j] == '1') // this is so long.
        //     {
        //         temp = listSent[j];
        //         temp += listSent[j + 1];
        //         temp += listSent[j + 2];
        //         j += 3;
        //         Console.WriteLine($"{temp}");
        //     }
        //     else if (listSent[j] == '3')
        //     {
        //         temp = listSent[j];
        //         temp += listSent[j + 1];
        //         Console.WriteLine($"{temp}");
        //         j += 2; // why does this work so funny ?
        //     }
        // } while (j < sentence.Length); // i <3 do loops
        string tempStr = "";
        int ascC;
        string output = "";
        foreach (char c in sentence) // had to do some extra research for this
        {
            tempStr += c;
            if (int.Parse(tempStr) > 96) // important to use str instead of int so it doesn't do arithmetic
            {
                ascC = int.Parse(tempStr);
                output += (char)ascC;
                tempStr = "";
            }
            else if (int.Parse(tempStr) == 32)
            {
                output += " ";
                tempStr = "";
            }
        }

        Console.WriteLine(output);
    }
}