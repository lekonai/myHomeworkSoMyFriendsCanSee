namespace A122;

public class Warrior
{
    private string name;
    protected int currentHealth;
    protected int maxHealth;
    private int attackDamage;

    public Warrior(string myName)
    {
        name = myName;
        maxHealth = 100;
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

    public void Attack(Warrior enemy, int diceRoll)
    {
        Console.WriteLine("ATTACK! WITH {0} DAMAGE!", diceRoll);
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