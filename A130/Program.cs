using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace A130;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer (0-99)");
        int inp = int.Parse(Console.ReadLine()); // get number req
        Console.WriteLine("Calculate additive or multiplicative persistence (a or m)?");
        string perInp = Console.ReadLine(); // get pers input
        int count = 0;
        int cNum = inp;
        do
        {
            if (perInp == "a")
            {
                cNum = (cNum / 10) + (cNum % 10); // i need to read the question, i just realised this is how you get left hand and right hand faster
            }
            else
            {
                cNum = (cNum / 10) * (cNum % 10);
            }
            count++;
        } while (cNum > 9);
        
        Console.WriteLine("The persistence of {0} is {1}", inp, count);


    }
}

