using System.Threading.Channels;

namespace W137___Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> wordsReps = new Dictionary<string, int>();
        string inp = Console.ReadLine();
        string[] words = inp.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            if (wordsReps.ContainsKey(words[i]))
            {
                wordsReps[words[i]]++;
            }
            else
            {
                wordsReps.Add(words[i], 1);
            }
        }

        foreach (string key in wordsReps.Keys)
        {
            Console.WriteLine("{0} - {1}", key, wordsReps[key]);
        }
    }
}