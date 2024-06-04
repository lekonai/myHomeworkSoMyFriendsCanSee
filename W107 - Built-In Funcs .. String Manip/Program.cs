using System.Threading.Channels;

namespace W107;

class Program
{
    static void Main(string[] args)
    {
        
    }

    static void Task1_E()
    {
        List<int> ascList = new List<int>();
        bool choice = false;
        while (choice == false)
        {
            Console.WriteLine("Enter an ASCII number thingy: ");
            int inp = int.Parse(Console.ReadLine());
            ascList.Add(inp);
            Console.WriteLine("\nOkay, awesome, now would you like to enter another one? Y/N ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.N)
            {
                choice = true;
            }
            else
            {
                choice = false;    
            }
            Console.WriteLine("");
        }

        for (int i = 0; i < ascList.Count; i++)
        {
            Console.Write("{0}", Convert.ToChar(ascList[i]));
        }
    }
    static void Task1_D()
    {
        // what is d asking from me ??
    }
    static void Task1_C()
    {
        Random randy = new Random();
        int currentInt = randy.Next(65, 123);
        char theChar = Convert.ToChar(currentInt);
        Console.WriteLine(theChar);
    }

    static void Task1_B()
    {
        Console.WriteLine("Enter a sentence to use");
        string theSen = Console.ReadLine(); // gets sentence
        
        Console.Write("Enter the phrase to find:");
        string inp = Console.ReadLine();
        
        bool detected = theSen.Contains(inp);
        if (detected == true)
        {
            Console.WriteLine("The phrase IS in the sentence!");
        }
        else
        {
            Console.WriteLine("Yeah we couldn't find it nerd.");
        }
    }
    static void Task1_A()
    {
        Console.WriteLine("Enter a sentence to use");
        string theSen = Console.ReadLine(); // gets sentence
        
        Console.Write("Enter the character to use:");
        string inp = Console.ReadLine();
        char theChar = Convert.ToChar(inp);

        for (int i = 0; i < theSen.Length; i++)
        {
            if (theSen[i] == theChar)
            {
                Console.WriteLine("Character {0} found at position {1} in the sentence", theChar, i + 1);
            }
        }
    }
    static void Task0()
    {
        string inp1, inp2;
                do
                {
                    Console.WriteLine("Enter your FN");
                    inp1 = Console.ReadLine();
                } while (inp1.Length < 4);
                
                do
                {
                    Console.WriteLine("Enter your SN");
                    inp2 = Console.ReadLine();
                } while (inp2.Length < 4);
        
                string theName = inp1.Substring(0, 3) + inp2.Substring(0, 3);
                Console.WriteLine(theName);
    }
}