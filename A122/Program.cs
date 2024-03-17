namespace A122;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many sides would you like on your die?: ");
        int inp = int.Parse(Console.ReadLine());
        Dice myDice = new Dice(inp);
        Warrior bigMAN = new Warrior("robert");
        Console.WriteLine("Just created the hero, their name is: {0}, and the big guy's got {1} health", bigMAN.GetName(), bigMAN.GetHealth());
        Warrior smallMAN = new Warrior("obscurenameInsertHERE");
        Console.WriteLine("And in the other corner of the ring, we have the small GUY. Their name is: {0}, and the big guy's got {1} health", smallMAN.GetName(), smallMAN.GetHealth());
        while (bigMAN.isAlive() && smallMAN.isAlive())
        {
            Console.WriteLine("Hero turn.");
            bigMAN.Attack(smallMAN,myDice.Roll());
            Console.WriteLine("Enemy turn");
            smallMAN.Attack(bigMAN,myDice.Roll());
            Console.WriteLine(" ");
        }

        if (bigMAN.GetHealth() > smallMAN.GetHealth())
        {
            Console.WriteLine("{0} WINS! THEY WIN WITH {1} HEALTH WHILE THE LOSER HAS {2} HEALTH!", bigMAN.GetName(), bigMAN.GetHealth(), smallMAN.GetHealth());
        }
        else
        {
            Console.WriteLine("{0} WINS! THEY WIN WITH {1} HEALTH WHILE THE LOSER HAS {2} HEALTH!", smallMAN.GetName(), smallMAN.GetHealth(), bigMAN.GetHealth());
        }
    }
}
