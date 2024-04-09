using System.Diagnostics.Contracts;

namespace A122;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many sides would you like on your die?: ");
        int inp = int.Parse(Console.ReadLine());
        Dice myDice = new Dice(inp);
        HealingWarrior bigMAN = new HealingWarrior("robert");
        Console.WriteLine("Just created the hero, their name is: {0}, and the big guy's got {1} health", bigMAN.GetName(), bigMAN.GetHealth());
        Mage smallMAN = new Mage("obscurenameInsertHERE", 10, 15);
        Console.WriteLine("And in the other corner of the ring, we have the small GUY. Their name is: {0}, and the big guy's got {1} health", smallMAN.GetName(), smallMAN.GetHealth());
        Console.WriteLine("\n======== FIGHT BEGINS ========\n");
        while (bigMAN.isAlive() && smallMAN.isAlive())
        {
            Console.WriteLine("Hero turn. You have {0} health", bigMAN.GetHealth());
            // health bar code here
            // Console.Write("[");
            // for (int i = 0; i < HealthDivider(bigMAN.GetHealth()); i++)
            // {
            //     Console.Write("#");
            // }
            //
            // for (int i = 0; i < 10 - (HealthDivider(bigMAN.GetHealth()) + 1); i++)
            // {
            //     Console.Write(" ");
            // }
            // Console.Write("]");
            
            // noted, gonna try make a subroutine so it's nice :)
            HealthBarCreator(bigMAN);
            Console.WriteLine(""); // spacer
            bigMAN.Attack(smallMAN,myDice.Roll());
            Console.WriteLine(""); // next part is the enemy's turn
            
            Console.WriteLine("Enemy turn. Enemy has {0} health", smallMAN.GetHealth());
            // health bar code here
            HealthBarCreator(smallMAN);
            Console.WriteLine(""); // spacer
            smallMAN.Attack(bigMAN,myDice.Roll());
            Console.WriteLine(" ");
            if (bigMAN.getHaveHealed() == false)
            {
                Console.WriteLine("Wanna heal? y/n");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    bigMAN.heal();
                }
                else
                {
                    Console.WriteLine("\n=== The fight continues... ===\n");
                }
            }
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

    static int HealthDivider(int inpHealth)
    {
        int out1 = inpHealth / 10;
        return out1;
    }

    static void HealthBarCreator(Warrior warINP)
    {
        Console.Write("[");
        for (int i = 0; i < HealthDivider(warINP.GetHealth()); i++)
        {
            Console.Write("#");
        }
        
        for (int i = 0; i < 10 - (HealthDivider(warINP.GetHealth()) + 1); i++)
        {
            Console.Write(" ");
        }
        Console.Write("]");
    }
}
