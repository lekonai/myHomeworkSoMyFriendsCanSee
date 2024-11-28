using System.Xml.Linq;

namespace A210;

class Program
{
    static void Main(string[] args)
    {
        string Data = "8% of 60 is 4.8";
        List<char> dataList = Data.ToList();
        List<char> oneZeroList = new List<char>()
            { 'a', 'b', 'd', 'e', 'g', 'o', 'p', 'q', '0', '6', '9', 'D', 'O', 'P', 'Q', 'R', '@' };
        var oneZero = dataList.GroupBy(x => x).Select(g =>
            (g.Contains('a') || g.Contains('b') || g.Contains('d') || g.Contains('e') || g.Contains('g') ||
             g.Contains('o') || g.Contains('p') || g.Contains('q') || g.Contains('0') || g.Contains('6') || g.Contains('9') || g.Contains('D') || g.Contains('0') || g.Contains('P') || g.Contains('Q') || g.Contains('R') || g.Contains('@'))
            ); // wow, just because you can't infer, you have to have explicit arguments
        var twoZero = dataList.GroupBy(x => x)
            .Select(g => g.Contains('%') || g.Contains('&') || g.Contains('B') || g.Contains('8'));
        int zeroCount = 0;
        foreach (var oz in oneZero)
        {
            if (oz)
            {
                zeroCount++;
            }
        }
        foreach (var tz in twoZero)
        {
            if (tz)
            {
                zeroCount += 2;
            }
        }
        for (int i = 0; i < dataList.Count; i++)
        {
            if (dataList[i] == '(')
            {
                if (dataList[i + 1] == ')')
                {
                    zeroCount++;
                    i++;
                }
            }
        }
        Console.WriteLine($"The amount of Os in this string is: {zeroCount}");
    }
}