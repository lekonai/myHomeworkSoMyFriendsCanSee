namespace A122;

public class Warrior
{
    private string name;
    protected int currentHealth;
    protected const int maxHealth = 100;
    private int attackDamage;

    public Warrior(string myName)
    {
        name = myName;
        currentHealth = maxHealth;
        attackDamage = 10;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public string GetName()
    {
        return name;
    }

    public bool isAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }

        return false;
    }

    public virtual void  Attack(Warrior enemy, int diceRoll)
    {
        Console.WriteLine("ATTACK! WITH {0} AS THE MODIFIER!", diceRoll);
        enemy.Attacked(diceRoll,attackDamage);
    }

    public void Attacked(int diceRoll, int attackedDamage)
    {
        currentHealth -= diceRoll * attackedDamage;
        Console.WriteLine("Just lost {0} health :(", diceRoll * attackedDamage);
    }
}

public class HealingWarrior : Warrior
{
    private bool haveHealed;

    public HealingWarrior(string myName) : base(myName)
    {
        haveHealed = false;
    }

    public void heal()
    {
        Console.WriteLine($"You heal! Your health goes from {currentHealth} to {maxHealth}");
        currentHealth = maxHealth;
        haveHealed = true;
    }

    public bool getHaveHealed()
    {
        return haveHealed;
    }
}

public class Mage : Warrior
{
    private int mana;
    private int maxMana;
    private int magicDamage;

    public Mage(string inName, int inmaxMana, int inmagicDamage) : base(inName)
    {
        maxMana = inmaxMana;
        magicDamage = inmagicDamage;
        mana = maxMana;
    }
    public override void Attack(Warrior enemy, int diceRoll)
    {
        if (mana < maxMana)
        {
            mana += 10;
            if (mana > 10)
            {
                mana = 10;
            }
            Console.WriteLine("Not enough mana to attack, mana has been added instead; your mana is now {0}", mana);
        }
        else
        {
            mana = 0;
            Console.WriteLine("ATTACK! WITH {0} AS THE MODIFIER!", diceRoll);
            enemy.Attacked(diceRoll,magicDamage);
        }
        
    }

    public int getMana()
    {
        return mana;
    }
    
}