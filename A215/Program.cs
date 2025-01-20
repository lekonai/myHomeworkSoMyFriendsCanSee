namespace A215;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(BPCCDoorperson("llamas"));
    }

    static int BPCCDoorperson(string str)
    {
        bool doubleDetected = false;
        int numReturned = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (i < str.Length - 1)
            {
                if (str[i] == str[i + 1])
                {
                    numReturned = (i + 1) * 3;
                    doubleDetected = true;
                }
            }
        }

        if (!doubleDetected)
        {
            return -1;
        } 
        return numReturned;
    }
}