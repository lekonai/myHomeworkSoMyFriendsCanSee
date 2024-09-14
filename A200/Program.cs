namespace A200;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string inp = Console.ReadLine();
            int num = Alphabets(inp);
            Console.WriteLine(num);
        }
    }

    static int Alphabets(string inp)
    {
        inp = inp.ToLower(); // amendment lol.
        int amountOfAlphabetLetters = 0;
        for (int i = 0; i < inp.Length; i++)
        {
            int cCharAlphabetPosition = inp[i] - 96;
            int cPosition = i + 1;
            if (cCharAlphabetPosition == cPosition)
            {
                amountOfAlphabetLetters++;
            }
        }
        return amountOfAlphabetLetters;
    }
}