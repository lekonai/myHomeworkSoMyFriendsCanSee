namespace A121;

public class PizzaOrder
{
    private string address;
    private int diameter;
    private List<string> toppings;

    public PizzaOrder(string addressToDeliver, int size, List<string> listOfToppings) // this is a constructor !
    {
        address = addressToDeliver;
        diameter = size;
        toppings = listOfToppings;
    }

    public int getPrice()
    {
        double pizzaArea = Math.Pow((diameter / 2), 2) * Math.PI;
        int price = ((int)pizzaArea / 10) + toppings.Count + 2;
        return price;
    }

    public void getSummary()
    {
        Console.WriteLine("The address to deliver to is: {0}\nThe diameter of the pizza is {1} inches", address, diameter);
        Console.WriteLine("Your toppings consist of: ");
        foreach (var i in toppings)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("And the price should be £{0}", getPrice());
    } 
    
}