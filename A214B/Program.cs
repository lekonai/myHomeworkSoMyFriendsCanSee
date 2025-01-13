namespace A214B;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[] {7,5,9 };
        int[] b = new int[] {2,4,6,8 };

        if (attacked(a, b))
        {
            Console.WriteLine("You survived the attack!");
        }
        else
        {
            Console.WriteLine("You all perish.");
        }
    }

    static bool attacked(int[] atk, int[] dfd)
    {
        int longer = 0; // 0 = balanced, 1 attacker is longer, 2 defender is longer.
        int aSurv = 0;
        int dSurv = 0;
        int limit = Math.Min(atk.Length, dfd.Length); // limit of for loop.
        if (atk.Length < dfd.Length)
        {
            longer = 2;
        }
        if (atk.Length > dfd.Length)
        {
            longer = 1;
        }
        else
        {
            longer = 0;
        }

        for (int i = 0; i < limit; i++)
        {
            if (atk[i] < dfd[i])
            {
                dSurv++;
            }
            else if (dfd[i] < atk[i])
            {
                aSurv++;
            }
        }

        if (longer == 1)
        {
            aSurv += dfd.Length - limit;
        }
        else if (longer == 2)
        {
            dSurv += atk.Length - limit;
        }

        if (dSurv >= aSurv)
        {
            return true;
        }
        return false;
    }
}