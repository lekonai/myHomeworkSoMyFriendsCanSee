namespace A214;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(WordEnator("8plus7minus9plus3"));
    }

    static int WordEnator(string n)
    {
        int num = n[0] - 48; 
        // minus = 5, plus = 4
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == 'p')
            {
                num += n[i + 4] - 48;
            }
            if (n[i] == 'm')
            {
                num -= n[i + 5] - 48;
            }
        }

        return num;
    }
}