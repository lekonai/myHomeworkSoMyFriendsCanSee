using Microsoft.VisualBasic.CompilerServices;

namespace A119;

class Program
{
    struct ediblePawnCoord
    {
        public int ePX;
        public int ePY;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Generating 8x8 chess board...");
        string[,] chessBoard = new string[8, 8]; // can't make char 2D array ?? why. nvm that was me.
        int rookX, rookY, pawnX, pawnY;
        bool edible = false; // can the rook take the pawn??
        
        // fill it all with gaps:
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                chessBoard[i, j] = " ";
            }
        }

        // get coord of rook

        Console.WriteLine("Rook X Coord: ");
        rookX = getCoord();
        Console.WriteLine("Rook Y Coord: ");
        rookY = getCoord();
        chessBoard[rookX, rookY] = "R"; // WHY DOESN'T WORK ohh i forgot to put in a value.
        bool pawnGenerator = false;
        while (pawnGenerator == false)
        {
            Console.WriteLine("Pawn X Coord: ");
            pawnX = getCoord();
            Console.WriteLine("Pawn Y Coord: ");
            pawnY = getCoord();
            chessBoard[pawnX, pawnY] = "P";
            
            Console.WriteLine("Make a new pawn? Y/N");
            ConsoleKeyInfo generatorInput = Console.ReadKey();
            if (generatorInput.Key == ConsoleKey.Y)
            {
                pawnGenerator = false;
                Console.WriteLine();
            }
            else
            {
                pawnGenerator = true;
                Console.WriteLine();
            }
        }
        
        // Console.WriteLine("Second Pawn: ");
        // Console.WriteLine("Pawn X Coord: ");
        // pawnX = int.Parse(Console.ReadLine());
        // pawnX -= 1;
        // Console.WriteLine("Pawn Y Coord: ");
        // pawnY = int.Parse(Console.ReadLine());
        // pawnY -= 1;
        // chessBoard[pawnX, pawnY] = "P";
        
        // print board, same method as before but with |
        // int ediblePawnCount = 0; now a useless variable
        List<ediblePawnCoord> ediblePawnList = new List<ediblePawnCoord>();
        for (int i = 0; i < 8; i++)
        {
            Console.Write("|");
            for (int j = 0; j < 8; j++)
            {
                Console.Write(chessBoard[i,j] + "|"); // chess board written
                // this will check it during it, as a rook only needs row/col, this should work.
                if (chessBoard[i, j] == "P" && (i == rookX || j == rookY))
                {
                    edible = true;
                    ediblePawnCoord edibleRightNow = new ediblePawnCoord();
                    edibleRightNow.ePX = i;
                    edibleRightNow.ePY = j;
                    ediblePawnList.Add(edibleRightNow);
                }
            }
            Console.WriteLine();
        }
        // i just realised that all the code i've just done is, while it's robust, it is not the quickest way
        // i could just do this:
        // if (pawnX == rookX || pawnY == rookY)
        // {
        //     edible = true;
        // }
        // nvm i misread it, you need two pawns.
        int ediblePawnCounterForReaderToLove = 1; // unnecessarily long name
        if (edible)
        {
            Console.WriteLine("yeah you can take a pawn or two !");
            foreach (var i in ediblePawnList)
            {
                Console.WriteLine("Pawn Number {0} that's available to eat: ", ediblePawnCounterForReaderToLove);
                Console.WriteLine("This is it's X: {0}", i.ePX + 1);
                Console.WriteLine("This is it's Y: {0}", i.ePY + 1); // + 1 is for the sake of human
                ediblePawnCounterForReaderToLove++;
            }
        }
        else
        {
            Console.WriteLine("nope");
        }
        
    }

    public static int getCoord()
    {
        int num = 0;
        bool isValid = false;
        while (isValid == false)
        {
            try
            {
                num = int.Parse(Console.ReadLine());
                if (num > 8 || num < 1)
                {
                    throw new IndexOutOfRangeException("Stupid Idiot. (They'll never see this, this is just filler text");
                } // need this now
                

                num -= 1;
                isValid = true;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Yeah... that's not valid, thank you, please keep it as an integer between 1 and 8");
                // getCoord(); // i love recursive programming
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please, use the correct data type (int)");
            }
        }
        
        
        
        return num;
    }
    
}