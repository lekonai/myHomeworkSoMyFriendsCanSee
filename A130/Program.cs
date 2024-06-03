using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace A130;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer (0-99)");
        string inp = Console.ReadLine(); // get number req
        Console.WriteLine("Calculate additive or multiplicative persistence (a or m)?");
        string perInp = Console.ReadLine(); // get pers input
        int cNum = int.Parse(inp);
        do
        {
            string cNumSTR = cNum.ToString();
            int[] theNumArray = new int[2];
            theNumArray[0] = cNumSTR[0];
            Console.WriteLine(theNumArray[0]);
            theNumArray[1] = cNumSTR[1];
            Console.WriteLine(theNumArray[1]);
            if (perInp == "a")
            {
                cNum = theNumArray[0] + theNumArray[1];
            }
            else
            {
                cNum = theNumArray[0] * theNumArray[1];
            }
        } while (cNum > 9);
        
        Console.WriteLine("The persistence of {0} is {1}", inp, cNum);


    }
}

