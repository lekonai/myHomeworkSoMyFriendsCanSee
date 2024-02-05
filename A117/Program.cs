
namespace A117;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what's your binary input?");
        string input = Console.ReadLine();
        
        Console.WriteLine("what's your position?");
        int pos = int.Parse(Console.ReadLine());

        string theFlip = binaryFlip(input, pos);
        Console.WriteLine("flipped: {0}", theFlip); // output
    }

    static string binaryFlip(string input, int pos)
    {
        char[] stringBuilder = input.ToCharArray();
        
        for (int i = pos - 1; i < input.Length; i++) // successful.
        {
            // char currentChar = input[i]; // to read the character; maybe not necessary? idk.
            if (stringBuilder[i] == '1')
            {
                // Console.WriteLine("this is a 1");
                stringBuilder[i] = '0';
            }

            else if (stringBuilder[i] == '0')
            {
                // Console.WriteLine("this is a 0");
                stringBuilder[i] = '1';
            }
        }
        
        string newString = "";
        foreach (var i in stringBuilder)
        {
            newString += i;
        }

        return newString;
    }
}