namespace A208;

class Program
{
    static void Main(string[] args)
    {
        bool dishBringTrue = feast("ron weasley", "raspberry trifle");
        if (dishBringTrue)
        {
            Console.WriteLine("Yes, you can bring in this dish");
        }
        else if (!dishBringTrue)
        {
            Console.WriteLine("No, you can bring in this dish");    
        }

        Console.ReadKey();
    }

    static bool feast(string student, string dish)
    {
        bool firstChars = false;
        bool lastChars = false;
        char firstCharST = student[0];
        char lastCharST = student[^1];
        char firstCharDS = dish[0];
        char lastCharDS = dish[^1];
        if (firstCharST == firstCharDS)
        {
            firstChars = true;
        }

        if (lastCharST == lastCharDS)
        {
            lastChars = true;
        }
        if (firstChars && lastChars)
        {
            return true;
        }
        return false;
    }
}