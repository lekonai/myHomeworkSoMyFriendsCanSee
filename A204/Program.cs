namespace A204;

class Program
{
    static void Main(string[] args)
    {
        string input = "nouveau";
        Console.WriteLine(VowelSender(input));
    }

    static string VowelSender(string n)
    {
        string newString = "";
        List<string> ar = new List<string>();
        foreach (var v in n)
        {
            ar.Add(v.ToString());
        }
        string addToEnd = "";
        for (int i = 0; i < ar.Count; i++)
        {
            if (ar[i].Contains("a") || ar[i].Contains("e") || ar[i].Contains("i") || ar[i].Contains("o") || ar[i].Contains("u"))
            {
                addToEnd += ar[i];
            }
            else
            {
                newString += ar[i];
            }
        }
        
        return newString = newString += addToEnd;
    }
}