using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace A134;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string inp = Console.ReadLine();
        if (isDisarium(inp))
        {
            Console.WriteLine("{0} is a Disarium number", inp);
        }
        else
        {
            Console.WriteLine("{0} is not a Disarium number", inp);
        }
    }
    // researching enumerables... i wonder what those are. documentation so confusing...
    static bool isDisarium(string n)
    {
        double total = 0;
        int m = 0;
        if (int.TryParse(n, out m))
        {
            for (int i = 0; i < n.Length; i++)
            {
                int numToUse = n[i] - '0';
                total += Math.Pow(numToUse, i + 1);
            }
        }
        else
        {
            return false; // this is false if it's not a number !
        }

        if (m == total)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}