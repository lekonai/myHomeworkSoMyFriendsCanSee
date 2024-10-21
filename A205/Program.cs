namespace A205;

class Program
{
    static void Main(string[] args)
    {
        bool happy = HappyNumberTest(55);
        if (happy)
        {
            Console.WriteLine("happy number :)");  
        }
        else if (happy == false)
        {
            Console.WriteLine("not happy number D:");  
        }
        
    }

    static bool HappyNumberTest(int inp)
    {
        // int[] invalidNumbers = new[] { 1, 4, 16, 20, 37, 42, 58, 89 }; // okay i can't use this
        // int endNumber = inp;
        //
        // while (endNumber != 1 && endNumber != 4 && endNumber != 16 && endNumber != 20 && endNumber != 37 && endNumber != 42 && endNumber != 58 && endNumber != 89) // spent 10 minutes trying to find a quicker way of doing this... nvm.
        // {
        //     inp = endNumber;
        //     endNumber = 0;
        //     while (inp > 0)
        //     {
        //         int currentDigit = inp % 10;
        //         endNumber = endNumber + currentDigit^2;
        //         inp = inp / 10;
        //     }
        // }
        // if (endNumber == 1)
        // {
        //     return true;
        // }
        // return false;
        
        int sum = 0;
        int endNum = 0;
        var numbers = new HashSet<int>(); // this thing is genius, it stops repetition
        while(endNum != 1)
        {
            sum += (inp%10) * (inp%10); // will never go above 100, i hope.
            inp /= 10;
            if(inp == 0 && endNum != 1)
            {
                if (!numbers.Add(sum)) // hash set utility is here. this stops 4 and those invalid numbers prior mentioned
                {
                    break; 
                }
                inp = sum;
                endNum = sum; // hope that endnum is 
                sum = 0; // reset for next iteration
            }
        }
        
        if (endNum == 1)
        {
            return true;
        }
        return false;
        
        // i've spent so long on this oh my god
        
    }
}