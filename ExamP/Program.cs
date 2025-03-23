namespace ExamP;

class Program
{
    public static void Main(string[] args)
    {
        int number;

        do
        {
            Console.Write("Enter an integer greater than 0: ");
            if (int.TryParse(Console.ReadLine(), out number) && number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 0.");
            }
        } while (number <= 0); // is there a typo on the exam?

        if (IsIncreasing(number))
        {
            Console.WriteLine($"{number} is not a bouncy number because it is an increasing number.");
        }
        else if (IsDecreasing(number))
        {
            Console.WriteLine($"{number} is not a bouncy number because it is a decreasing number.");
        }
        else if (IsPerfectlyBouncy(number))
        {
            Console.WriteLine($"{number} is a perfectly bouncy number.");
        }
        else
        {
            Console.WriteLine($"{number} is a bouncy number.");
        }
    }

    public static bool IsIncreasing(int number)
    {
        string numStr = number.ToString();
        for (int i = 1; i < numStr.Length; i++)
        {
            if (numStr[i] < numStr[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsDecreasing(int number)
    {
        string numStr = number.ToString();
        for (int i = 1; i < numStr.Length; i++)
        {
            if (numStr[i] > numStr[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsBouncy(int number)
    {
        return !IsIncreasing(number) && !IsDecreasing(number);
    }

    public static bool IsPerfectlyBouncy(int number)
    {
        if (!IsBouncy(number))
        {
            return false;
        }

        string numStr = number.ToString();
        int largerCount = 0;
        int smallerCount = 0;

        for (int i = 0; i < numStr.Length - 1; i++)
        {
            if (numStr[i] < numStr[i + 1])
            {
                largerCount++;
            }
            else if (numStr[i] > numStr[i + 1])
            {
                smallerCount++;
            }
        }

        return largerCount == smallerCount;
    }
}