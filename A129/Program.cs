namespace A129;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(pattern(11));
        Console.WriteLine(unique("L3_37"));
    }

    static string pattern(int n)
    {
        string rString = ""; // return string
        for (int i = 1; i <= n; i++)
        {
            string tString = ""; // temp string
            for (int j = 0; j < i; j++)
            {
                tString = tString + i;
            }
            rString = rString + tString;
            rString = rString + "\n"; // add line
        }
        
        return rString; // so glad i figured out a way without recursion
    }

    static bool unique(string inp)
    {
        List<char> charCMP = new List<char>();
        for (int i = 0; i < inp.Length; i++)
        {
            char tChar; // temp char
            tChar = inp[i]; // make it equal to current part
            if (i == 0)
            {
                charCMP.Add(tChar); // just for the first step
            }
            else if (i > 0)
            {
                for (int j = 0; j < charCMP.Count; j++)
                {
                    if (charCMP[j] == tChar)
                    {
                        return false; // it's found one just like it ! nuh uhhh return false.
                    }
                }
                charCMP.Add(tChar); // all clear, add char to list
            }
        }
        return true; // gone through the entire thing atp
    }
}