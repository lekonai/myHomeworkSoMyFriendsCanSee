using System.Threading.Channels;

namespace W137___Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> wordsReps = new Dictionary<string, int>();
        string inp = Console.ReadLine();
        string[] words = inp.Split(" ");
        for (int i = 0; i < inp.Length; i++)
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

        // foreach (string in COLLECTION)
        // {
        //     
        // }
    }
}