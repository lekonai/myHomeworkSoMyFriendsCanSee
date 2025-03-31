namespace A224;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(isAutomorphic(5));
        VorC("It matters not what someone is born, but what they grow to be.");
    }

    static bool isAutomorphic(int n)
    {
        int nsq = n * n;
        if (n.ToString()[^1] == nsq.ToString()[^1])
        {
            return true;
        }

        return false;
    }
    
    static void VorC(string str)
    {
        str = str.ToLower();
        int vowels = 0;
        int cons = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
                vowels++;
            }
            else if (str[i] == '.' || str[i] == ' ')
            {
                
            }
            else
            {
                cons++;
            }
        }
        Console.WriteLine($"{vowels} {cons}");
    }
}