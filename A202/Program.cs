namespace A202;

class Program
{
    static void Main(string[] args)
    {
        BubbleSort(); // completed in 7m 40s, but realistically finished the algorithm in about 6m 30s and sorted out where my logic error was after that.
    }

    static void BubbleSort()
    {
        int[] bAr = { 93, 46, 85, 90, 66, 57, 75, 5, 33, 45 };
        bool sorted;
        do
        {
            sorted = true;
            for (int i = 0; i < bAr.Length - 1; i++)
            {
                int temp1 = bAr[i];
                int temp2 = bAr[i + 1];
                if (temp2 < temp1)
                {
                    bAr[i] = temp2;
                    bAr[i + 1] = temp1;
                    sorted = false;
                }
            }
        } while (sorted == false);

        for (int i = 0; i < bAr.Length; i++)
        {
            Console.WriteLine(bAr[i]);
        }
    }
}