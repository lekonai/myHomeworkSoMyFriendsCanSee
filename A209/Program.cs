namespace A209;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Numbers(input);
    }

    static void Numbers(int iniNum)
    {
        string numString = NumberMap(iniNum);
        Console.WriteLine(numString);
        string newString = "";
        int actualNum = 0;
        while (true)
        {
            newString = NumberMap(numString.Length);
            Thread.Sleep(250);
            if (numString == newString)
            {
                break;
            }
            Console.WriteLine(newString);
            numString = newString;
        }
        
    }

    static string NumberMap(int input)
    {
        Dictionary<int, string> numberMap = new Dictionary<int, string>()
        {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" }
        }; // dictionary set up
        string numString = "";

        for (int i = 0; i < input.ToString().Length; i++)
        {
            numString += numberMap[input.ToString()[i] - 48];
        }

        return numString;
    }
}
