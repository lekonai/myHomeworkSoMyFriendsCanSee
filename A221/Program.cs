namespace A221;

class Program
{
    static void Main(string[] args)
    {
        Potion FelixFelicis = new Potion(192, 192, 192, 10);
        Potion PolyJuice = new Potion(0,128,0,5);
        Potion EndPotion = new Potion(0,0,0,0);
        EndPotion = FelixFelicis.mix(PolyJuice);
        Console.WriteLine("WEEE GOT a new potion! Here are the stats:");
        Console.WriteLine("Colour: {0}", EndPotion.getColour());
        Console.WriteLine("Volume: {0}", EndPotion.getVolume());
        
    }
}

public class Potion()
{
    protected List<int> colours = new List<int>(){0,0,0};
    protected int volume;
    
    public Potion(int r, int g, int b, int vol) : this()
    {
        colours[0] = r;
        colours[1] = g;
        colours[2] = b;
        volume = vol;
    }

    public (int, int, int) getColour()
    {
        return (colours[0], colours[1], colours[2]);
    }

    public int getVolume()
    {
        return volume;
    }

    public Potion mix(Potion secPot)
    {
        // (fpColour * fpVol + sPotColour * sPotVol) / (fpVol + sPotVol)
        Potion thirdPot = new Potion(0, 0, 0, 0);
        for (int i = 0; i < colours.Count; i++)
        {
            thirdPot.colours[i] = (colours[i] * volume + secPot.colours[i] * secPot.volume) / (volume * secPot.volume);
        }
        thirdPot.volume = volume + secPot.volume;
        return thirdPot;
    }
}