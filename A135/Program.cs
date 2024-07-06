using System.Xml;

namespace A135;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input A String: ");
        string input = "";
        input = Console.ReadLine(); // please don't put anything null inside.
        string[] output = Conversion(input);
        Dictionary<string, string> letters = new Dictionary<string, string>()
        {
            { "11", "A" },
            { "12", "B" },
            { "13", "C/K" },
            { "14", "D" },
            { "15", "E" },
            { "21", "F" },
            { "22", "G" },
            { "23", "H" },
            { "24", "I" },
            { "25", "J" },
            { "31", "L" },
            { "32", "M" },
            { "33", "N" },
            { "34", "O" },
            { "35", "P" },
            { "41", "Q" },
            { "42", "R" },
            { "43", "S" },
            { "44", "T" },
            { "45", "U" },
            { "51", "V" },
            { "52", "W" },
            { "53", "X" },
            { "54", "Y" },
            { "55", "Z" }
        };
        // this is such a clunky way of doing it
        Console.WriteLine(TapDecodeLetter(letters, output));
        
    }
    
    static string TapDecodeLetter(Dictionary<string, string> letters, string[] inp)
    {
        string output = "";
        int tempNum1 = 0;
        int tempNum2 = 0;
        int whenOdd = 0;
        string combine = "";
        for (int i = 0; i < inp.Length; i += 2)
        {
            foreach (var v in inp[i])
            {
                tempNum1++;
            }
            foreach (var b in inp[i + 1])
            {
                tempNum2++;
            }

            combine = tempNum1.ToString() + tempNum2.ToString();
            output += letters[combine];
            tempNum1 = 0;
            tempNum2 = 0;
        }
        
        return output;
    }
    
    
    static string[] Conversion(string n)
    {
        string[] finish = n.Split(' ');
        return finish;
    }
}