namespace A122;

public class Dice
{
    private int sidesCount;
    private Random randy = new Random();

    public Dice()
    {
        sidesCount = 6;
    }

    public Dice(int sides) // unspecified as to what the param is to do in the hw, tutut
    {
        sidesCount = sides;
    }

    public int GetSidesCount()
    {
        return sidesCount;
    }

    public int Roll()
    {
        int num = randy.Next(1, sidesCount + 1);
        return num;
    }
}