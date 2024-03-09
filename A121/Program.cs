namespace A121;

class Program
{
    static void Main(string[] args)
    {
        List<string> tops = new List<string>();

        Console.WriteLine("Thank you for ordering from 'Computers Ordered My Pizzas, Secret Company Inc.', your order is being calculated");
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(1000);
     
        tops.Add("ham");
        tops.Add("pineapple");
        tops.Add("anchovies");
        tops.Add("olives");
        tops.Add("a cuddly toy");


        PizzaOrder newOrder = new PizzaOrder("Barton Peveril, SO50 5ZA", 12, tops);

        Console.WriteLine("The pizza you have ordered comes to £" + newOrder.getPrice());
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Please confirm that this is correct:");
        Console.WriteLine("--------------------");
        newOrder.getSummary();
        Console.WriteLine("--------------------");
        Console.ReadKey();
    }

}