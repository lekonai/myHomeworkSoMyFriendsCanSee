namespace A120;

class Program
{
    static void Main(string[] args)
    {
        Random randy = new Random();
        int[,] theGrid = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int currentRandom = randy.Next(0,100);
                theGrid[i, j] = currentRandom; // fills out the grid
            }
        }
        // let's make an easy total finder
        
        // int row1T = TotalFinder(theGrid, ref rowCount);
        // int row2T = TotalFinder(theGrid, ref rowCount);
        // int row3T = TotalFinder(theGrid, ref rowCount);
        // int row4T = TotalFinder(theGrid, ref rowCount);
        // int row5T = TotalFinder(theGrid, ref rowCount);
        int rowCount = 0; // because global variables are illegal or something
        int[] rowTotals = new int[5];
        int highestRTotal = 0;
        int rowWHighestTotal = 0;
        for (int i = 0; i < 5; i++)
        {
            rowTotals[i] = TotalFinder(theGrid, ref rowCount);
            if (rowTotals[i] > highestRTotal)
            {
                highestRTotal = rowTotals[i];
                rowWHighestTotal = i;
            }
        }
        
        int colWHighestTotal = 0;
        int highestCTotal = 0;
        int[] colTotals = new int[5];
        int colCount = 0;
        for (int i = 0; i < 5; i++)
        {
            colTotals[i] = TotalColFinder(theGrid, ref colCount);
            // Console.WriteLine(colTotals[i]);
            if (colTotals[i] > highestCTotal)
            {
                highestCTotal = colTotals[i];
                colWHighestTotal = i;
            }
        }
        // Console.ForegroundColor = ConsoleColor.Red;
        
        // int rowTotal = 0;
        int rowTotalCounter = 0;
        for (int i = 0; i < 5; i++)
        {
            // bool totalAddHappen = false;
            if (i == rowWHighestTotal)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write("|");
            for (int j = 0; j < 5; j++)
            {
                // if (totalAddHappen == false)
                // {
                //     for (int k = 0; k < 5; k++)
                //     {
                //         rowTotal += theGrid[i, 0 + k];
                //     }
                //     totalAddHappen = true;
                // }
                
                // rowTotal += theGrid[i, j];
                
                // DOESNT WORK RN.
                
                // if (j == colWHighestTotal)
                // {
                //     Console.ForegroundColor = ConsoleColor.Blue; // this is testing atm
                // }
                // else if (j != colWHighestTotal || i != rowWHighestTotal)
                // {
                //     Console.ForegroundColor = ConsoleColor.Gray;
                // }
                
                // THIS PART DOESN'T 
                
                Console.Write("{0}", theGrid[i,j]); // print out tha grid !
                Console.Write("|");
            }
            
            Console.Write(" Total for this Row: {0}", rowTotals[rowTotalCounter]);
            rowTotalCounter++;
            // if (rowTotal > highestRTotal)
            // {
            //     highestRTotal = rowTotal; // cmp and highest total
            // }
            // rowTotal = 0;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
        }
        // Console.WriteLine("The highest row total was {0}", highestRTotal); // testing only
        
        // testing part:

        for (int i = 0; i < colTotals.Length; i++)
        {
            Console.WriteLine("Col Total: {0}", colTotals[i]);
            if (i == colWHighestTotal)
            {
                Console.WriteLine("this is the highest total");
            }
        }
    }

    public static int TotalFinder(int[,] grid, ref int rowC) // for rows
    {
        int rowT = 0;
        for (int i = rowC; i < rowC + 1; i++) 
        {
            for (int j = rowC; j < 5; j++)
            {
                rowT += grid[i, j];
            }
        }
        

        rowC++;
        return rowT;
    }

    public static int TotalColFinder(int[,] grid, ref int colC)
    {
        int colT = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == colC)
                {
                    colT += grid[i,j];
                }
            }
        }

        colC++;
        return colT; // WHY DOES THIS W?A?AWF?AWF??AWF
    }
}