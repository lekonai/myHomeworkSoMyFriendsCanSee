using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace A111
{
    class Program
    {

        public static List<char> StringToList(string stringToUse) // turns a string into a list
        {
            List<char> theList = new List<char>();
            for (int i = 0; i < stringToUse.Length; i++)
            {
                theList.Add(stringToUse[i]);
            }

            return theList;
        }
        static public int count = 0;
        public static int CountCharsInList(List<char> listingItUp) // counts the chars in a list.
        {
            //List<string> listButString = new List<string>();
            //for (int i = 0; i < listingItUp.Count; i++)
            //{
            //    listButString.Add(listingItUp[i].ToString());
            //}
            int vowelCount = 0;
            if (count == 0)
            {
                int theA;
                for (int i = 0; i < listingItUp.Count; i++)
                {
                    if (listingItUp[i].ToString().ToLower() == "a")
                    {
                        vowelCount++;
                    }
                    else { }
                }
                count++;
                return vowelCount;
            }
            if (count == 1)
            {
                int theE;
                for (int i = 0; i < listingItUp.Count; i++)
                {
                    if (listingItUp[i].ToString().ToLower() == "e")
                    {
                        vowelCount++;
                    }
                    else { }
                }
                count++;
                return vowelCount;
            }
            if (count == 2)
            {
                int theI;
                for (int i = 0; i < listingItUp.Count; i++)
                {
                    if (listingItUp[i].ToString().ToLower() == "i")
                    {
                        vowelCount++;
                    }
                    else { }
                }
                count++;
                return vowelCount;
            }
            if (count == 3)
            {
                int theO;
                for (int i = 0; i < listingItUp.Count; i++)
                {
                    if (listingItUp[i].ToString().ToLower() == "o")
                    {
                        vowelCount++;
                    }
                    else { }
                }
                count++;
                return vowelCount;
            }
            if (count == 4)
            {
                int theU;
                for (int i = 0; i < listingItUp.Count; i++)
                {
                    if (listingItUp[i].ToString().ToLower() == "u")
                    {
                        vowelCount++;
                    }
                    else { }
                }
                count++;
                return vowelCount;
            }

            return 0; // unusable atm
        }

        static void Main(string[] args)
        {
            // functiions n that
            string thePhrase;
            Console.WriteLine("Enter a phrase or something:");
            thePhrase = Console.ReadLine();
            List <char> listBeingHandled = StringToList(thePhrase);
            //for (int i = 0; i < listBeingHandled.Count; i++)
            //{
            //    Console.WriteLine("{0}", listBeingHandled[i]);
            //} // ok, so string to use works.
            Console.WriteLine("The amount of As is: {0}", CountCharsInList(listBeingHandled));
            Console.WriteLine("The amount of Es is: {0}", CountCharsInList(listBeingHandled));
            Console.WriteLine("The amount of Is is: {0}", CountCharsInList(listBeingHandled));
            Console.WriteLine("The amount of Os is: {0}", CountCharsInList(listBeingHandled));
            Console.WriteLine("The amount of Us is: {0}", CountCharsInList(listBeingHandled));
        }
    }
}
