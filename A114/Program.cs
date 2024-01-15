using System.Reflection.PortableExecutable;

namespace A114
{
    class Program
    {
        // wow, whoever wrote this REALLY likes procedural programming.
        struct film // structure of films
        {
            public string title;
            public int runtime;
            public bool currentOn;
        }
        static void Main(string[] args)
        {
            List<film> filmList = new List<film>(); // creates a list with the film struct
            int numOfFilms; // number of films
            string choice, filename; // file name and... somethin

            do
            {
                choice = menuchoice(); // go to menu choice to pick the choice
                switch (choice)
                {
                    case "1":
                        filename = getfilename();
                        filmList = readBinaryFile(filename); // UNCOMMENT this when you have written the readBinaryFile function
                        displayList(filmList);
                        break;
                    case "2":
                        filename = getfilename();
                        numOfFilms = getNumOfFilms();
                        filmList = getFilmInfo(numOfFilms);
                        writeBinaryFile(filename, numOfFilms, filmList); // UNCOMMENT this when you have written the writeBinaryFile function
                        break;
                    case "9":
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        // Add in a function to read from a binary file here. Make sure it is called "readBinaryFile"
        // Instructions for this function are in the assignment.
        // When it is written you can uncomment out the line that calls it in the switch statement above
        
        // wait. the assignment TELLS YOU WAHT T ODO?? ive just bneen sat here trying to decode it
        static List<film> readBinaryFile(string filename)
        {
            List<film> fList = new List<film>();
            film currentFilm;

            using (BinaryReader br = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                int filmNum = br.ReadInt32();
                for (int i = 0; i < filmNum; i++)
                {
                    currentFilm.title = br.ReadString();
                    currentFilm.runtime = br.ReadInt32();
                    currentFilm.currentOn = br.ReadBoolean();
                    fList.Add(currentFilm);

                }
            }
            return fList;
        }



        // Add in a procedure to write to a binary file. Make sure it is called "writeBinaryFile"
        // Instructions for this procedure are in the assignment.
        // When it is written you can uncomment out the line that calls it in the switch statement above

        static void writeBinaryFile(string fName, int numFilm, List<film> filmList) // you can't public this, that's strange :0
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(fName, FileMode.OpenOrCreate)))
            {
                bw.Write(filmList.Count);
                for (int i = 0; i< filmList.Count; i++)
                {
                    bw.Write(filmList[i].title);
                    bw.Write(filmList[i].runtime);
                    bw.Write(filmList[i].currentOn);

                }
            }
        }


        static string getfilename()
        {
            string filename;
            Console.WriteLine("Enter name of file including extension");
            filename = Console.ReadLine();
            return filename;
        }
        static int getNumOfFilms()
        {
            int numOfFilms;
            Console.WriteLine("How many films do you want to enter?");
            numOfFilms = int.Parse(Console.ReadLine());
            return numOfFilms;
        }
        static void displayList(List<film> filmList)
        {
            Console.WriteLine("Title".PadRight(30) + "Run Time".PadLeft(8) + "Current".PadLeft(10));
            for (int i = 0; i < filmList.Count; i++)
            {
                Console.WriteLine(filmList[i].title.PadRight(30) + " " + filmList[i].runtime.ToString().PadLeft(7) + filmList[i].currentOn.ToString().PadLeft(10));
            }
            Console.WriteLine();
        }
        static List<film> getFilmInfo(int numOfFilms)
        {
            List<film> listOfFilms = new List<film>();
            film tempFilm = new film();
            for (int i = 0; i < numOfFilms; i++)
            {
                Console.WriteLine("Enter film title");
                tempFilm.title = Console.ReadLine();
                Console.WriteLine("Enter film running time");
                tempFilm.runtime = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter if film is currently on (true or false)");
                tempFilm.currentOn = bool.Parse(Console.ReadLine());
                listOfFilms.Add(tempFilm);
            }
            return listOfFilms;
        }
        static string menuchoice()
        {
            string choice;
            menu();
            choice = Console.ReadLine();
            return choice;
        }
        static void menu()
        {
            Console.WriteLine("The Barton Cinema Files");
            Console.WriteLine();
            Console.WriteLine("1. Read in film information from a binary file");
            Console.WriteLine("2. Write film information into a binary file");
            Console.WriteLine();
            Console.WriteLine("9. Exit");
            Console.WriteLine();
            Console.WriteLine("Please type in the number of your choice");
        }
    }

}
