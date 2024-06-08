using System.Runtime.InteropServices;

namespace A131;

class Program
{
    static void Main(string[] args)
    {
        // mi cr ow av es
        Console.WriteLine("Enter a sentence: ");
        string inp = Console.ReadLine();
        Console.WriteLine("Microwave [1]\nPairs [2]");
        ConsoleKeyInfo oneOrTheOther = Console.ReadKey();
        Console.WriteLine("");
        if (oneOrTheOther.Key == ConsoleKey.D1)
        {
            Console.WriteLine(MicrowaveCipher(inp));
        }
        else
        {
            Console.WriteLine(PairsCipher(inp));
        }


    }

    static public string PairsCipher(string n)
    {
        string output = "";
        if (n.Length % 2 == 0) 
        {
            Console.WriteLine("this is an even");
            for (int i = 0; i < n.Length; i += 2)
            {
                output += n[i + 1];
                output += n[i];
            }
        }
        else if (n.Length % 2 > 0) // odd scenario
        {
            for (int i = 0; i < n.Length; i += 2)
            {
                if (i < n.Length - 2)
                {
                    output += n[i + 1];
                    output += n[i];
                }

                if (i == n.Length - 1)
                {
                    output += n[i];
                }
                
            }
        }
        
        
        return output;
    }
    static public string MicrowaveCipher(string inp)
    {
        string encrypted = "";
        for (int i = 0; i < inp.Length; i++)
        {
            switch (inp[i])
            {
                case 'M':
                    encrypted += 'I'; // i'm sure there's a faster way of doing this. oh well
                    break;
                case 'm':
                    encrypted += 'i';
                    break;
                case 'I':
                    encrypted += "M";
                    break;
                case 'i':
                    encrypted += "m";
                    break;
                case 'C':
                    encrypted += 'R';
                    break;
                case 'c':
                    encrypted += 'r';
                    break;
                case 'R':
                    encrypted += 'C';
                    break;
                case 'r':
                    encrypted += 'c';
                    break;
                case 'O':
                    encrypted += 'W';
                    break;
                case 'o':
                    encrypted += 'w';
                    break;
                case 'W':
                    encrypted += 'O';
                    break;
                case 'w':
                    encrypted += 'o';
                    break;
                case 'A':
                    encrypted += 'V';
                    break;
                case 'a':
                    encrypted += 'v';
                    break;
                case 'V':
                    encrypted += 'A';
                    break;
                case 'v':
                    encrypted += 'a';
                    break;
                case 'E':
                    encrypted += 'S';
                    break;
                case 'e':
                    encrypted += 's';
                    break;
                case 'S':
                    encrypted += 'E';
                    break;
                case 's':
                    encrypted += 'e';
                    break;
                case ' ':
                    encrypted += ' ';
                    break;
                default:
                    encrypted += inp[i];
                    break;
            }
        }

        return encrypted;
    }
    
}