namespace A132;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(uncensor("*h*s *s v*ry *tr*ng*", "Tiiesae"));
        Console.WriteLine(uncensor("A**Z*N*", "MAIG"));
        Console.WriteLine(uncensor("xyz", ""));
    }

    static string uncensor(string n, string fill)
    {
        // n = sentence to decode
        string newString = "";
        int count = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == '*')
            {
                newString += fill[count];
                count++;
            }
            else
            {
                newString += n[i];
            }
        }
        return newString;
    }
}