namespace A219;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Mirror("rtarm efaapc","abcdefghijklmnopqrst"));
    }
    static string Mirror(string sen, string alph)
    {
        string newString = "";
        
        for (int i = 0; i < sen.Length; i++)
        {
            if (alph.Contains(sen[i]))
            {
                newString = newString + alph[^(alph.IndexOf(sen[i]) + 1)];
            }
            else
            {
                newString = newString + sen[i];
            }
        }

        return newString;
    }
}