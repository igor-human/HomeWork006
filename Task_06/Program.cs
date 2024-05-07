using Task_06;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 15, num2 = 0;

        Console.WriteLine("Додавання: " + Calculator.Add(num1, num2));
        Console.WriteLine("Віднімання: " + Calculator.Subtract(num1, num2));
        Console.WriteLine("Множення: " + Calculator.Multiply(num1, num2));

        try
        {
            Console.WriteLine("Ділення: " + Calculator.Divide(num1, num2));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
