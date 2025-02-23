namespace A216;

class Program
{
    static void Main(string[] args)
    {
        string input = "Yesterday, we bumped into Laura. It had to happen, but you can't deny the timing couldn't be worse. The mission to try and win her was a complete failure last month. By the way, she still has the diary I gave her. Anyhow, it hasn't been fun. I wanted to be done with it all.";
        string input2 =
            "Gryffindor were practising Quidditch. Aside from the rain it hadn't been a happy practice session. Snape had been spying on them. Fred and George wanted to drop a stink bomb on Snape, but Wood did not allow this. Snape would do anything to ensure that the Slytherin team win the Quidditch cup again.";
        Console.WriteLine(BPCCDecode(input2));
    }

    static string BPCCDecode(string n)
    {
        string[] splitSentences; // this one splits into different sentences
        List<int> positions = new List<int>(); // frick zero-indexing
        List<string> finalSentence = new List<string>();
        splitSentences = n.Split('.', '!', '?');
        string[] firstSentGetPos = splitSentences[0].Split(' ', ',');
        for (int i = 0; i < firstSentGetPos.Length; i++) // get positions required.
        {
            if (firstSentGetPos[i].Length > 0)
            {
                positions.Add(firstSentGetPos[i].Length);
            }
        }
        
        // ^^^^ okay this works ^^^^

        for (int j = 1; j < splitSentences.Length; j++)
        {
            if (finalSentence.Count == positions.Count)
            {
                break;
            } 
            int count = j - 1;
            // Console.WriteLine(positions[count]); // why is this such a problematic statement?
            int positionSeek = positions[count]; // why doesn't this work?? i'm so confused.
            int positionSeeking = 0;
            string[] tempArray = splitSentences[j].Split(' ', ',');
            for (int z = 0; z < tempArray.Length; z++)
            {
                if (positionSeeking != positionSeek)
                {
                    if (tempArray[z].Length > 0)
                    {
                        positionSeeking++;
                    }
                } 
                else if (positionSeeking == positionSeek)
                {
                    // Console.WriteLine(tempArray[z - 1]); // idk what the issue is but i've solved it with - 1
                    finalSentence.Add(tempArray[z - 1]);
                    break;
                }
            }
        }

        for (int i = 0; i < finalSentence.Count; i++)
        {
            Console.WriteLine(finalSentence[i]);
        }
        
        return " ";
    }
}