using System.ComponentModel.DataAnnotations;

namespace A203;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 6, 14, 24, 39, 57, 63, 88 }; // oh this is weird cause there's an even amount of.. okay
        Console.WriteLine(BinarySearch(array));
    }

    static string BinarySearch(int[] inp)
    {
        int left, right;
        int numToFind = 65; // enter the number you wanna find in here
        // 0, 1, 2, 3, 4, 5, 6, 7
        // no mid point so must evaluate 3 and 4 together#
        int count = 0; // max is 3
        left = inp[inp.Length / 2 - 1];
        right = inp[inp.Length / 2];
        if (numToFind < left)
        {
            left = inp[inp.Length / 4 - 1];
            right = inp[inp.Length / 4];
            if (numToFind < left)
            {
                if (numToFind == inp[0])
                {
                    return "found";
                }

                return "not found";
            }
            else if (numToFind > right)
            {
                return "not found";
            }
            else
            {
                return "found";
            }


        }
        else if (numToFind > right)
        {
            left = inp[inp.Length / 2 + 1];
            right = inp[inp.Length / 2 + 2];
            if (numToFind < left)
            {
                return "not found";
            }
            else if (numToFind > right)
            {
                right = inp[inp.Length - 1];
                if (numToFind == right)
                {
                    return "found";
                }
                else
                {
                    return "not found";
                }
            }
            else
            {
                return "found";
            }
        }
        else
        {
            return "found";
        }
            
        
        
        
        
        return "not found";
    }
}