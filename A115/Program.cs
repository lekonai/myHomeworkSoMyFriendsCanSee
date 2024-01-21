using System.Xml;

namespace A115
{
    internal class Program
    {
        //public const string alphabetIndex = "abcdefghijklmnopqrstuvwxyz";
        //public const string numberindex = "123456789";
        static public List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
        static void Main(string[] args)
        {
            Console.WriteLine("write in your input");
            string input = Console.ReadLine();
            Console.WriteLine(LetterChange(input));


        }


        static string LetterChange(string input)
        {
            // 1. shift 1 right DONE
            // 2. capitalise vowels. DONE
            string output = "";

            for (int i = 0; i < input.Length; i++) // changes it
            {
                int currentASCII = (int)input[i];

                if (currentASCII == 122)
                {
                    currentASCII = 97;
                }
                else
                {
                    currentASCII++;
                }
                // step 1 done
                //s tep 2 :
                if (vowels.Contains((char)currentASCII))
                {
                    output += char.ToUpper((char)currentASCII); // why is it this method to uppercase a char??
                }
                else
                {
                    output += (char)currentASCII;
                }
                
            }

            //List<char> newList = new List<char>(); // neverm ind this is too long , i'm gonna try refine something else
            //for (int i = 0; i < input.Length; i++)
            //{
            //    newList.Add(output[i]);
            //}
            return output;
        }
    }
}
