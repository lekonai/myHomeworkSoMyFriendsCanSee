namespace A113
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            part2.theMain();
            Console.WriteLine("Part 1:");
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (leap(year) == true)
            {
                Console.WriteLine("That's a leap year!");
            }
            else if (leap(year) == false)
            {
                Console.WriteLine("Not a leap year :(");
            }
        }

        static public bool leap(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
