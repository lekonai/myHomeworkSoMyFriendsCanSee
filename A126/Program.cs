using System.Reflection.Metadata.Ecma335;

namespace A126;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(solution()); // simple :)
    }

    static int solution() // i <3 procedural programming
    {
        Console.WriteLine("Enter a number");
        int theNum = int.Parse(Console.ReadLine());
        if (theNum == 0 || theNum < 0)
        {
            return 1;
        }
        Console.WriteLine("Do it Recursively? Y/n");
        ConsoleKeyInfo inp = Console.ReadKey();
        if (inp.Key == ConsoleKey.Y)
        {
            Console.WriteLine("");
            return recFactorial(theNum);
        }
        Console.WriteLine("");
        return itrFactorial(theNum);
    }
    static int itrFactorial(int num)
    {
        int sum = 1;
        do // first time using a do loop in a while
        {
            sum *= num;
            num -= 2;
        }while (num > 0);
        return sum;
    }
    static int recFactorial(int num)
    {
        if (num <= 0)
        {
            return 1;
        }
        return num * recFactorial(num - 2); // such a simple solution i spent too much time on.
    }
}