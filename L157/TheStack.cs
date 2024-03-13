using System.Security.Cryptography;

namespace L157;

public class TheStack
{
    private int[] theStack = new int[10];
    private int pointer = -1;

    public void Push(int input)
    {
        
        if (isFull() == false)
        {
            // Console.WriteLine("Put in a value:");
            // int input = int.Parse(Console.ReadLine());
            theStack[pointer + 1] = input;
            pointer++;
        }
        else
        {
            Console.WriteLine("Unable to push, the stack's full.");
        }
    }

    public int Pop()
    {
        if (isEmpty())
        {
            Console.WriteLine("You can't pop, the stack's empty.");
            return 0;
        }
        else
        {
            int popVal = theStack[pointer];
            pointer--;
            return popVal;
        }
    }

    public int Seek()
    {
        if (isEmpty() == false)
        {
            return theStack[pointer];   
        }
        Console.WriteLine("Stack's empty...");
        return 0;
    }

    public bool isEmpty()
    {
        if (pointer < 0)
        {
            return true;
        }
        return false;
    }

    public bool isFull()
    {
        if (pointer == theStack.Length)
        {
            return true;
        } 
        return false;
    }
}