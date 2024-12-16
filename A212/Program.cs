using System.Diagnostics;
using System.Reflection.Emit;
using System.Text.Json.Serialization;

namespace A212;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(stickyCalculator());
    }

    static double stickyCalculator()
    {
        double operand1 = 0;
        double operand2 = 0;
        double STICKY = 0;
        string oper = "";
        do
        {
            Console.WriteLine("enter your operator:");
            oper = Console.ReadLine();
        } while (oper != "+" && oper != "-" && oper != "*" && oper != "/");

        do
        {
            Console.WriteLine("enter your first value (make sure it's positive)"); // no error checking here no sir no thanks
            operand1 = float.Parse(Console.ReadLine());
        } while (operand1 < -0.4);
        do
        {
            Console.WriteLine("enter your second  value (make sure it's positive)");
            operand2 = float.Parse(Console.ReadLine());
        } while (operand2 < -0.4);
        operand1 = Math.Round(operand1);
        operand2 = Math.Round(operand2);
        STICKY = double.Parse($"{operand1}" + $"{operand2}");
        Console.WriteLine("Here's the sticky number: {0}", STICKY);
        switch (oper)
        {
            case "+":
                return STICKY + operand2;
            case "-":
                return STICKY - operand2;
            case "/":
                return Math.Round(STICKY / operand2);
            case "*":
                return STICKY * operand2;
        }
        // complete at 11:45
        return 0;
    }
}