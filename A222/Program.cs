namespace A222;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, int> necessaryDictionary = ColoursNErrors("wpetrificusutotalusuwuexpectoupatronumuwuwingardiumuleviosauwu");
        BarChartProducer(necessaryDictionary);
    }

    static Dictionary<char, int> ColoursNErrors(string str)
    {
        Dictionary<char, int> toBeReturned = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (!toBeReturned.ContainsKey(str[i])) // the only error was here, i forgot the exclamation mark.
            {
                toBeReturned.Add(str[i], 1);
            }
            else
            {
                toBeReturned[str[i]] += 1;
            }
        }

        return toBeReturned;
    }

    static void BarChartProducer(Dictionary<char, int> dict)
    {
        char[] errorsArray = new char[] { 'u', 'w', 'x', 'y', 'z' };
        for (int i = 0; i < errorsArray.Length; i++)
        {
            if (dict.ContainsKey(errorsArray[i]))
            {
                Console.WriteLine("{0}: {1}", errorsArray[i], dict[errorsArray[i]]);
            }
        }
    }
}