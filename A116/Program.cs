using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;

namespace A116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, put in some words");
            string input = Console.ReadLine();
            bool truth = Isogram(input);
            if (truth)
            {
                Console.WriteLine("This is an Isogram.");
            }
            else if (truth == false)
            {
                Console.WriteLine("This is not an Isogram.");
            }
        }

        static bool Isogram(string input)
        {
            List<char> seen = new List<char>();
            foreach (var i in input)
            {
                seen.Add(input[0]); // adds the letter to the register essentially
                input = input.Substring(1, input.Length - 1); // cut it off.
                if (input.Length != 0)
                {
                    if (seen.Contains(input[0]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
// Console.WriteLine("CUT TO: " + input); // the tester start
// Console.Write("TEST list: ");
// for (int j = 0; j < seen.Count; j++) // test if the array is eating
// {
//     Console.Write(seen[j] + "");
// }
// Console.WriteLine(""); // tester line end