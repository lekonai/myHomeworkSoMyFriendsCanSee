namespace L157;

class Program
{
    static void Main(string[] args)
    {
        // string postFixExpr = "1 2 3 - + 4 5 - 6 * 7 8 + + 9 + -";
        Console.WriteLine("Input RPN Expression: ");
        string input = Console.ReadLine();
        string[] sentenceSplit = input.Split(' ');
        TheStack rpnStack = new TheStack();
        for (int i = 0; i < sentenceSplit.Length; i++)
        {
            if (isInt(sentenceSplit[i]))
            {
                int currentNum = Convert.ToInt32(sentenceSplit[i]); 
                rpnStack.Push(currentNum);
                Console.WriteLine(currentNum);
            }
            else
            {
                int val2 = rpnStack.Pop();
                int val1 = rpnStack.Pop();
                switch (sentenceSplit[i])
                {
                    case "-":
                    {
                        rpnStack.Push(sub(val1,val2));
                        break;
                    }
                    case "+":
                    {
                        rpnStack.Push(add(val1,val2));
                        break;
                    }
                    case "*":
                    {
                        rpnStack.Push(mult(val1,val2));
                        break;
                    }
                    case "/":
                    {
                        rpnStack.Push(div(val1,val2));
                        break;
                    }
                }
            }
            
        }

        Console.WriteLine(rpnStack.Seek());
    }

    static bool isInt(string inp)
    {
        if (inp == "0" ||inp == "1" || inp == "2" || inp == "3" ||
            inp == "4" || inp == "5" || inp == "6" ||
            inp == "7" || inp == "8" || inp == "9")
        {
            return true;
        }
        return false;
    }

    static int sub(int left, int right)
    {
        int val = 0;
        val = left - right;
        return val;
    }

    static int add(int left, int right)
    {
        return left + right;
    }

    static int mult(int left, int right)
    {
        return left * right;
    }

    static int div(int left, int right)
    {
        return left / right;
    }
}