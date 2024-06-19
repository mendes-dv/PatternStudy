namespace FactoryPattern;

public class GooglePayPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} with Google Pay");
    }
}