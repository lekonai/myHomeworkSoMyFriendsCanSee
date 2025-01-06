namespace A213;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int treeSize = input - input % 3;
        Console.WriteLine(TreeBuilder(treeSize));

    }
    
    // why does it have to be a functioN/ can i not just make it a usbroutein? oikay....

    static string TreeBuilder(int n)
    {
        int m = ((n - 1) * 2 + 5) / 5; 
        int overallCount = 0;
        int count = 0;
        string endGap = "";
        int endGapLen = 0;
        for (int i = 1; i <= n; i += 2)
        {
            for (int k = 0; k < m; k++)
            {
                Console.Write(" ");
                if (k > endGapLen)
                {
                    endGapLen = k;
                }
            }
            m--;
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            overallCount++;
            if (overallCount == n)
            {
                break;
            } // probably could've been more efficient
            count++;
            if (count == 3)
            {
                count = 0;
                i -= 4;
                m += 2;
            }
        }

        for (int x = 0; x < endGapLen; x++)
        {
            endGap += " ";
        }
        return endGap + "###";
    }
}